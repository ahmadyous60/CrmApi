using CrmApi.DTOs;
using CrmApi.Models;
using Microsoft.EntityFrameworkCore;

public static class PermissionSeeder
{
    // Central place where all permissions are defined
    public static List<Permission> GetAllPermissions()
    {
        return new List<Permission>
        {
            // Users
            new Permission { Id = Guid.Parse("926E654E-7C2B-4C24-8C12-7A594A4008E0"), Name = PermissionConstants.Users.View, Description = "View users" },
            new Permission { Id = Guid.Parse("1B6FB93E-6E53-4385-B284-D72E1AC92873"), Name = PermissionConstants.Users.Add, Description = "Add users" },
            new Permission { Id = Guid.Parse("D4A75F2B-E9F1-4BF7-8713-4149F1C05D71"), Name = PermissionConstants.Users.Edit, Description = "Edit users" },
            new Permission { Id = Guid.Parse("185B4989-D80D-4BBC-9CC2-AAFC1D05F7ED"), Name = PermissionConstants.Users.Delete, Description = "Delete users" },

            // Leads
            new Permission { Id = Guid.Parse("E2F7C163-E7E8-49F7-9DD0-25662363524E"), Name = PermissionConstants.Leads.View, Description = "View leads" },
            new Permission { Id = Guid.Parse("E2E6F8CE-176F-4599-B92E-DCC5FB3050CB"), Name = PermissionConstants.Leads.Add, Description = "Add leads" },
            new Permission { Id = Guid.Parse("7AA1FD07-7726-414E-9DCE-1723586C128E"), Name = PermissionConstants.Leads.Edit, Description = "Edit leads" },
            new Permission { Id = Guid.Parse("82E99D1D-5DA6-4540-BFE1-0D9B4E8278BB"), Name = PermissionConstants.Leads.Delete, Description = "Delete leads" },
            new Permission { Id = Guid.Parse("61EBEA0B-5E99-445F-94DC-F90B6A62D631"), Name = PermissionConstants.Leads.Export, Description = "Export leads" },

            // Deals
            new Permission { Id = Guid.Parse("504672A9-2F7F-4480-9D06-4826A6DE01D5"), Name = PermissionConstants.Deals.View, Description = "View deals" },
            new Permission { Id = Guid.Parse("EA2A225B-01FB-4A95-A42B-6814A478B91D"), Name = PermissionConstants.Deals.Add, Description = "Add deals" },
            new Permission { Id = Guid.Parse("25D79875-6CBB-49DC-9FA0-F7FD1A5EF611"), Name = PermissionConstants.Deals.Edit, Description = "Edit deals" },
            new Permission { Id = Guid.Parse("17817170-947B-4E96-9E11-192B2FBED308"), Name = PermissionConstants.Deals.Delete, Description = "Delete deals" },
            new Permission { Id = Guid.Parse("ACD36735-5F59-4F12-BC1A-08B7A2DA6781"), Name = PermissionConstants.Deals.Export, Description = "Export deals" },

            // Contacts
            new Permission { Id = Guid.Parse("454F0F6A-A216-45AB-B78B-D2079CB4D608"), Name = PermissionConstants.Contacts.View, Description = "View contacts" },
            new Permission { Id = Guid.Parse("197DE633-9F35-4DA3-A20F-77D08F9843AB"), Name = PermissionConstants.Contacts.Add, Description = "Add contacts" },
            new Permission { Id = Guid.Parse("FD4AF3CB-DF9F-4307-8727-B77B10982E46"), Name = PermissionConstants.Contacts.Edit, Description = "Edit contacts" },
            new Permission { Id = Guid.Parse("62DE43A8-2855-44BA-871E-40E938396DF5"), Name = PermissionConstants.Contacts.Delete, Description = "Delete contacts" },
            new Permission { Id = Guid.Parse("B6C53F41-0129-4EE0-9C4F-37F7886ACD12"), Name = PermissionConstants.Contacts.Export, Description = "Export contacts" },

            // Companies
            new Permission { Id = Guid.Parse("BEFB6F03-7C95-4FFE-85F1-59BE64958175"), Name = PermissionConstants.Companies.View, Description = "View companies" },
            new Permission { Id = Guid.Parse("619E7D84-A439-496F-81C0-B4A979AF3C66"), Name = PermissionConstants.Companies.Add, Description = "Add companies" },
            new Permission { Id = Guid.Parse("0E29DAF9-7FAC-4FC8-9532-4E499E4AFDE7"), Name = PermissionConstants.Companies.Edit, Description = "Edit companies" },
            new Permission { Id = Guid.Parse("98BCFA90-8DE9-499E-9455-AAB4087D8C8A"), Name = PermissionConstants.Companies.Delete, Description = "Delete companies" },
            new Permission { Id = Guid.Parse("5CE44F6D-BC61-4E5D-9E25-1AF9304D65C9"), Name = PermissionConstants.Companies.Export, Description = "Export companies" },
        };
    }

    // Seeder calls the above
    public static void SeedPermissions(ModelBuilder builder)
    {
        builder.Entity<Permission>().HasData(GetAllPermissions());
    }
}
