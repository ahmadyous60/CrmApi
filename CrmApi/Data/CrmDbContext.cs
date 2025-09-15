using CrmApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrmApi.Data
{
    public class CrmDbContext : IdentityDbContext<IdentityUser>
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
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b); // important for Identity

            // Default CreatedAt for all entities
            b.Entity<Lead>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            b.Entity<Deal>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            b.Entity<Contact>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            b.Entity<Company>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            b.Entity<Note>().Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");

            // Length constraints
            b.Entity<Lead>().Property(x => x.Status).HasMaxLength(20);
            b.Entity<Lead>().Property(x => x.Source).HasMaxLength(20);
            b.Entity<Deal>().Property(x => x.Stage).HasMaxLength(20);

            // Polymorphic relation (Lead or Contact) for activities
            b.Entity<Models.Task>().Property(x => x.EntityType).HasMaxLength(20).IsRequired();
            b.Entity<Note>().Property(x => x.EntityType).HasMaxLength(20).IsRequired();
            b.Entity<Event>().Property(x => x.EntityType).HasMaxLength(20).IsRequired();
        }
    }
}
