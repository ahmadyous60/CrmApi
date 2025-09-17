using CrmApi.DTOs;
using CrmApi.Models;
using Microsoft.EntityFrameworkCore;

public static class PermissionSeeder
{
    public static void SeedPermissions(ModelBuilder builder)
    {
        var permissions = new List<Permission>
        {
            // Users
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Users.View, Description = "View users" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Users.Add, Description = "Add users" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Users.Edit, Description = "Edit users" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Users.Delete, Description = "Delete users" },

            // Leads
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Leads.View, Description = "View leads" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Leads.Add, Description = "Add leads" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Leads.Edit, Description = "Edit leads" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Leads.Delete, Description = "Delete leads" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Leads.Export, Description = "Export leads" },

            // Deals
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Deals.View, Description = "View deals" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Deals.Add, Description = "Add deals" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Deals.Edit, Description = "Edit deals" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Deals.Delete, Description = "Delete deals" },
                
            // Contacts
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Contacts.View, Description = "View contacts" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Contacts.Add, Description = "Add contacts" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Contacts.Edit, Description = "Edit contacts" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Contacts.Delete, Description = "Delete contacts" },

            // Companies
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Companies.View, Description = "View companies" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Companies.Add, Description = "Add companies" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Companies.Edit, Description = "Edit companies" },
            new Permission { Id = Guid.NewGuid(), Name = PermissionConstants.Companies.Delete, Description = "Delete companies" },
        };

        builder.Entity<Permission>().HasData(permissions);
    }
}
