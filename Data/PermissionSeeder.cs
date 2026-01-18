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

            //Tasks
             new Permission { Id = Guid.Parse("f7a4d2b8-318c-4db1-b8e7-fb01a1cdbf2a"), Name = PermissionConstants.Tasks.Add, Description = "Add Tasks" },
             new Permission { Id = Guid.Parse("1c32e594-5cb3-4df8-93df-5b74f62c3d56"), Name = PermissionConstants.Tasks.Edit, Description = "Edit Tasks" },
             new Permission { Id = Guid.Parse("f8bca6ce-3228-4e4c-a8d3-5e39f87ab01f"), Name = PermissionConstants.Tasks.Delete, Description = "Delete Tasks" },
             new Permission { Id = Guid.Parse("c15e24a9-d84f-45ce-8ad7-98f2f9b3d117"), Name = PermissionConstants.Tasks.Export, Description = "Export Tasks" }, 
             new Permission { Id = Guid.Parse("e2a6219a-3a5a-4c9c-83df-9d7a07d2bca1"), Name = PermissionConstants.Tasks.View, Description = "View Tasks" },

             //Notes
             new Permission { Id = Guid.Parse("b27a7f3b-f4c2-4d9d-93ab-9c452b6e8a12"), Name = PermissionConstants.Notes.Add, Description = "Add Notes" },
             new Permission { Id = Guid.Parse("d5a1d9d2-7c18-4cb7-8a1f-7b4d2a193ec8"), Name = PermissionConstants.Notes.Edit, Description = "Edit Nptes" },
             new Permission { Id = Guid.Parse("be3a7c89-9a6f-4e14-bb0f-9a82eac9dc52"), Name = PermissionConstants.Notes.Delete, Description = "Delete Notes" },
             new Permission { Id = Guid.Parse("0e75b1f8-7a04-43c2-bf3d-1348e0c3a9f5"), Name = PermissionConstants.Notes.Export, Description = "Export Notes" },
             new Permission { Id = Guid.Parse("31a1fef5-3d76-4bcf-8ed5-8024b6fa0b73"), Name = PermissionConstants.Notes.View, Description = "View Notes" },

               //Events
             new Permission { Id = Guid.Parse("a2b6b3dc-45e7-40d2-a1a1-6a7a03d93cf8"), Name = PermissionConstants.Events.Add, Description = "Add Events" },
             new Permission { Id = Guid.Parse("f0fdbb5f-3bda-49ee-8b2d-d93b2c52c1b7"), Name = PermissionConstants.Events.Edit, Description = "Edit Events" },
             new Permission { Id = Guid.Parse("7b18c8d1-1e0a-4b7e-81e3-723b2036a512"), Name = PermissionConstants.Events.Delete, Description = "Delete Events" },
             new Permission { Id = Guid.Parse("3f94d7c2-9915-4e54-b6cf-5a3e8d47d2b8"), Name = PermissionConstants.Events.Export, Description = "Export Events" },
             new Permission { Id = Guid.Parse("a59c32d4-ef6b-4d6b-a2a5-0edb5fcb9f66"), Name = PermissionConstants.Events.View, Description = "View Events" },

             //  ROLE PERMISSIONS MANAGEMENT
            new Permission { Id = Guid.Parse("5A60B76D-908F-4BEB-90B2-6A50B403BBAA"), Name = PermissionConstants.RolePermissions.View, Description = "View role permissions" },
            new Permission { Id = Guid.Parse("E9AAE54B-422A-4A5F-A057-44A8C5746C4D"), Name = PermissionConstants.RolePermissions.Manage, Description = "Manage role permissions" },

            //  AUDIT LOGS
            new Permission { Id = Guid.Parse("B92E30C9-8D9A-4D77-BF41-632FA458B884"), Name = PermissionConstants.AuditLogs.View, Description = "View audit logs" },
            new Permission { Id = Guid.Parse("F24A59F4-B36C-4C72-988A-5D9A3F4A6B67"), Name = PermissionConstants.AuditLogs.Export, Description = "Export audit logs" },

            new Permission { Id = Guid.Parse("7F82E971-84D8-41E5-92E7-9B78883C0154"), Name = PermissionConstants.AuditLogs.RequestView, Description = "View request audit logs" },
            new Permission { Id = Guid.Parse("CC9B5E44-6E6D-4374-B935-90D223BC26D4"), Name = PermissionConstants.AuditLogs.EntityView, Description = "View entity audit logs" },
        };
    }

    // Seeder calls the above
    public static void SeedPermissions(ModelBuilder builder)
    {
        builder.Entity<Permission>().HasData(GetAllPermissions());
    }
}
