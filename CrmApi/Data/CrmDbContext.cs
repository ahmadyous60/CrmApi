using CrmApi.DTOs;
using CrmApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrmApi.Data
{
    public class CrmDbContext : IdentityDbContext<ApplicationUser>
    {
        public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options) { }

        // CRM Entities
        public DbSet<Lead> Leads => Set<Lead>();
        public DbSet<Deal> Deals => Set<Deal>();
        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<Company> Companies => Set<Company>();

        // Activity Entities
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<AuditLog> AuditLogs { get; set; }

        // Security & Auth
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        //public DbSet<RolePermission> RolePermissions { get; set; }
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
    }
}
