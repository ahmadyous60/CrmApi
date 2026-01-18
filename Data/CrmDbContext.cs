using CrmApi.DTOs;
using CrmApi.Models;
using CrmApi.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text.Json;

namespace CrmApi.Data
{
    public class CrmDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly ICurrentUserService? _currentUserService;
        public string CurrentUserId => _currentUserService?.UserId ?? "System";
        public string CurrentUserName => _currentUserService?.UserName ?? "System";

        public CrmDbContext(DbContextOptions<CrmDbContext> options, ICurrentUserService? currentUserService = null)
            : base(options)
        {
            _currentUserService = currentUserService;
        }

        // CRM Entities
        public DbSet<Lead> Leads => Set<Lead>();
        public DbSet<Deal> Deals => Set<Deal>();
        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<Company> Companies => Set<Company>();

        // Activity Entities
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EntityAuditLog> EntityAuditLogs { get; set; }
        public DbSet<RequestAuditLog> RequestAuditLogs { get; set; }

        // Security & Auth
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RoleAccess> RoleAccesses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // Required for Identity tables

            // Default CreatedAt for entities
            builder.Entity<Lead>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            builder.Entity<Deal>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            builder.Entity<Contact>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            builder.Entity<Company>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            builder.Entity<Note>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");

            // Length constraints
            builder.Entity<Lead>().Property(x => x.Status).HasMaxLength(20);
            builder.Entity<Lead>().Property(x => x.Source).HasMaxLength(20);
            builder.Entity<Deal>().Property(x => x.Stage).HasMaxLength(20);

            // Polymorphic relation (Lead or Contact) for activities
            builder.Entity<Models.Task>()
                .Property(x => x.EntityType)
                .HasMaxLength(20)
                .IsRequired();

            builder.Entity<Note>()
                .Property(x => x.EntityType)
                .HasMaxLength(20)
                .IsRequired();

            builder.Entity<Event>()
                .Property(x => x.EntityType)
                .HasMaxLength(20)
                .IsRequired();

            // RoleAccess relationships
            builder.Entity<RoleAccess>()
                .HasOne(r => r.Role)
                .WithMany()
                .HasForeignKey(r => r.RoleId);

            builder.Entity<RoleAccess>()
                .HasOne(r => r.Permission)
                .WithMany(p => p.RoleAccessses)
                .HasForeignKey(r => r.PermissionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed initial permissions & role access
            PermissionSeeder.SeedPermissions(builder);
            RoleAccessSeeder.SeedRoleAccess(builder);
        }

        public override int SaveChanges()
        {
            var auditEntries = OnBeforeSaveChanges();

            using var transaction = Database.BeginTransaction();
            try
            {
                var result = base.SaveChanges();

                SaveAuditLogs(auditEntries);

                transaction.Commit();
                return result;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var auditEntries = OnBeforeSaveChanges();

            await using var transaction = await Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var result = await base.SaveChangesAsync(cancellationToken);

                await SaveAuditLogsAsync(auditEntries, cancellationToken);

                await transaction.CommitAsync(cancellationToken);
                return result;
            }
            catch
            {
                await transaction.RollbackAsync(cancellationToken);
                throw;
            }
        }

        private static readonly string[] ExcludedEntities =
        {
            nameof(RequestAuditLog),
            nameof(RefreshToken),
            nameof(EntityAuditLog),
            nameof(RoleAccess),
            nameof(Permission)
        };

        private List<TempAuditEntry> OnBeforeSaveChanges()
        {
            ChangeTracker.DetectChanges();
            var auditEntries = new List<TempAuditEntry>();

            foreach (var entry in ChangeTracker.Entries().Where(e =>
                e.State == EntityState.Added ||
                e.State == EntityState.Modified ||
                e.State == EntityState.Deleted))
            {
                var entityName = entry.Entity.GetType().Name;

                // Skip excluded entities
                if (ExcludedEntities.Contains(entityName))
                    continue;

                // Also skip self-audit logs
                if (entry.Entity is EntityAuditLog)
                    continue;

                var temp = new TempAuditEntry(entry)
                {
                    UserId = CurrentUserId,
                    UserName = CurrentUserName,
                    EntityName = entityName
                };

                foreach (var prop in entry.Properties)
                {
                    var propName = prop.Metadata.Name;

                    if (prop.Metadata.IsShadowProperty() ||
                        prop.Metadata is Microsoft.EntityFrameworkCore.Metadata.INavigation ||
                        prop.Metadata.IsConcurrencyToken ||
                        propName.ToLower().Contains("password") ||
                        propName.ToLower().Contains("token") ||
                        propName.ToLower().Contains("stamp"))
                        continue;

                    if (prop.Metadata.IsPrimaryKey())
                    {
                        temp.KeyValues[propName] = prop.CurrentValue;
                        continue;
                    }

                    switch (entry.State)
                    {
                        case EntityState.Added:
                            temp.Action = "Create";
                            temp.NewValues[propName] = prop.CurrentValue;
                            temp.ChangedColumns.Add(propName);
                            break;

                        case EntityState.Deleted:
                            temp.Action = "Delete";
                            temp.OldValues[propName] = prop.OriginalValue;
                            break;

                        case EntityState.Modified:
                            if (!Equals(prop.OriginalValue, prop.CurrentValue))
                            {
                                temp.Action = "Update";
                                temp.ChangedColumns.Add(propName);
                                temp.OldValues[propName] = prop.OriginalValue;
                                temp.NewValues[propName] = prop.CurrentValue;
                            }
                            break;
                    }
                }

                // Skip if no real changes
                if (entry.State == EntityState.Modified && temp.ChangedColumns.Count == 0)
                    continue;

                auditEntries.Add(temp);
            }

            return auditEntries;
        }


        private void SaveAuditLogs(List<TempAuditEntry> auditEntries)
        {
            if (!auditEntries.Any()) return;

            foreach (var a in auditEntries)
            {
                foreach (var pk in a.Entry.Properties.Where(p => p.Metadata.IsPrimaryKey()))
                    a.KeyValues[pk.Metadata.Name] = pk.CurrentValue;

                var oldValuesStr = a.OldValues.Any()
                    ? string.Join(" ", a.OldValues.Values.Where(v => v != null))
                    : null;

                var newValuesStr = a.NewValues.Any()
                    ? string.Join(" ", a.NewValues.Values.Where(v => v != null))
                    : null;

                EntityAuditLogs.Add(new EntityAuditLog
                {
                    Id = Guid.NewGuid(),
                    UserId = a.UserId,
                    UserName = a.UserName,
                    Action = a.Action,
                    EntityName = a.EntityName,
                    EntityId = JsonSerializer.Serialize(a.KeyValues),
                    ChangedColumns = a.ChangedColumns.Any() ? string.Join(", ", a.ChangedColumns) : null,
                    OldValues = oldValuesStr,
                    NewValues = newValuesStr,
                    Timestamp = DateTime.UtcNow
                });
            }

            base.SaveChanges();
        }

        private async System.Threading.Tasks.Task SaveAuditLogsAsync(List<TempAuditEntry> auditEntries, CancellationToken cancellationToken)
        {
            if (!auditEntries.Any()) return;

            foreach (var a in auditEntries)
            {
                foreach (var pk in a.Entry.Properties.Where(p => p.Metadata.IsPrimaryKey()))
                    a.KeyValues[pk.Metadata.Name] = pk.CurrentValue;

                var oldValuesStr = a.OldValues.Any()
                    ? string.Join(" ", a.OldValues.Values.Where(v => v != null))
                    : null;

                var newValuesStr = a.NewValues.Any()
                    ? string.Join(" ", a.NewValues.Values.Where(v => v != null))
                    : null;

                await EntityAuditLogs.AddAsync(new EntityAuditLog
                {
                    Id = Guid.NewGuid(),
                    UserId = a.UserId,
                    UserName = a.UserName,
                    Action = a.Action,
                    EntityName = a.EntityName,
                    EntityId = JsonSerializer.Serialize(a.KeyValues),
                    ChangedColumns = a.ChangedColumns.Any() ? string.Join(", ", a.ChangedColumns) : null,
                    OldValues = oldValuesStr,
                    NewValues = newValuesStr,
                    Timestamp = DateTime.UtcNow
                }, cancellationToken);
            }

            await base.SaveChangesAsync(cancellationToken);
        }

        private class TempAuditEntry
        {
            public TempAuditEntry(EntityEntry entry) { Entry = entry; }
            public EntityEntry Entry { get; }
            public string? UserId { get; set; }
            public string? UserName { get; set; }
            public string EntityName { get; set; } = string.Empty;
            public string Action { get; set; } = string.Empty;
            public Dictionary<string, object?> KeyValues { get; } = new();
            public Dictionary<string, object?> OldValues { get; } = new();
            public Dictionary<string, object?> NewValues { get; } = new();
            public List<string> ChangedColumns { get; } = new();
        }
    }
}
