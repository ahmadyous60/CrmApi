//using CrmApi.Models;
//using Microsoft.EntityFrameworkCore;

//public static class RoleAccessSeeder
//{
//    public static void SeedRoleAccess(ModelBuilder builder)
//    {
//        var roleAccesses = new List<RoleAccess>
//        {
//            // ================= USER (View-only) =================
//            new RoleAccess { Id = Guid.Parse("10000000-0000-0000-0000-000000000004"), RoleId = "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a", PermissionId = Guid.Parse("454F0F6A-A216-45AB-B78B-D2079CB4D608") }, // Contacts.View
//            new RoleAccess { Id = Guid.Parse("10000000-0000-0000-0000-000000000005"), RoleId = "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a", PermissionId = Guid.Parse("BEFB6F03-7C95-4FFE-85F1-59BE64958175") }, // Companies.View

//            // ================= ADMIN (CRU) ===================

//            // Leads
//            new RoleAccess { Id = Guid.Parse("4460BE55-45FC-4725-8F75-1EF5875F6BBA"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("E2F7C163-E7E8-49F7-9DD0-25662363524E") }, // View Leads
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000006"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("E2E6F8CE-176F-4599-B92E-DCC5FB3050CB") }, // Add Leads
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000007"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("7AA1FD07-7726-414E-9DCE-1723586C128E") }, // Edit Leads

//            // Deals
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000010"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("504672A9-2F7F-4480-9D06-4826A6DE01D5") }, // View Deals
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000011"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("EA2A225B-01FB-4A95-A42B-6814A478B91D") }, // Add Deals
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000012"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("25D79875-6CBB-49DC-9FA0-F7FD1A5EF611") }, // Edit Deals

//            // Contacts
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000014"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("454F0F6A-A216-45AB-B78B-D2079CB4D608") }, // View Contacts
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000015"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("197DE633-9F35-4DA3-A20F-77D08F9843AB") }, // Add Contacts
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000016"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("FD4AF3CB-DF9F-4307-8727-B77B10982E46") }, // Edit Contacts

//            // Companies
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000018"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("BEFB6F03-7C95-4FFE-85F1-59BE64958175") }, // View Companies
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000019"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("619E7D84-A439-496F-81C0-B4A979AF3C66") }, // Add Companies
//            new RoleAccess { Id = Guid.Parse("20000000-0000-0000-0000-000000000020"), RoleId = "1e13facc-515f-40d1-8c0d-196a8374e104", PermissionId = Guid.Parse("0E29DAF9-7FAC-4FC8-9532-4E499E4AFDE7") }, // Edit Companies

//            // ================= SUPERADMIN (ALL) =================
//        };

//        // SuperAdmin gets ALL permissions
//        var allPermissionIds = new[]
//        {
//            "82E99D1D-5DA6-4540-BFE1-0D9B4E8278BB","7AA1FD07-7726-414E-9DCE-1723586C128E","17817170-947B-4E96-9E11-192B2FBED308",
//            "E2F7C163-E7E8-49F7-9DD0-25662363524E","62DE43A8-2855-44BA-871E-40E938396DF5","D4A75F2B-E9F1-4BF7-8713-4149F1C05D71",
//            "504672A9-2F7F-4480-9D06-4826A6DE01D5","0E29DAF9-7FAC-4FC8-9532-4E499E4AFDE7","BEFB6F03-7C95-4FFE-85F1-59BE64958175",
//            "EA2A225B-01FB-4A95-A42B-6814A478B91D","197DE633-9F35-4DA3-A20F-77D08F9843AB","926E654E-7C2B-4C24-8C12-7A594A4008E0",
//            "98BCFA90-8DE9-499E-9455-AAB4087D8C8A","185B4989-D80D-4BBC-9CC2-AAFC1D05F7ED","619E7D84-A439-496F-81C0-B4A979AF3C66",
//            "FD4AF3CB-DF9F-4307-8727-B77B10982E46","454F0F6A-A216-45AB-B78B-D2079CB4D608","1B6FB93E-6E53-4385-B284-D72E1AC92873",
//            "E2E6F8CE-176F-4599-B92E-DCC5FB3050CB","25D79875-6CBB-49DC-9FA0-F7FD1A5EF611","61EBEA0B-5E99-445F-94DC-F90B6A62D631"
//        };

//        int counter = 1;
//        foreach (var permId in allPermissionIds)
//        {
//            roleAccesses.Add(new RoleAccess
//            {
//                Id = Guid.Parse($"30000000-0000-0000-0000-{counter.ToString("D12")}"),
//                RoleId = "38e3e873-009f-4765-bfab-e58b39f12c64",
//                PermissionId = Guid.Parse(permId)
//            });
//            counter++;
//        }

//        builder.Entity<RoleAccess>().HasData(roleAccesses);
//    }
//}



//using CrmApi.Models;
//using Microsoft.EntityFrameworkCore;

//public static class RoleAccessSeeder
//{
//    public static void SeedRoleAccess(ModelBuilder builder)
//    {
//        var userRoleId = "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a";
//        var adminRoleId = "1e13facc-515f-40d1-8c0d-196a8374e104";
//        var superAdminRoleId = "38e3e873-009f-4765-bfab-e58b39f12c64";

//        // load all permissions you seeded earlier
//        var permissions = PermissionSeeder.GetAllPermissions();

//        var roleAccesses = new List<RoleAccess>();
//        int counter = 1;

//        foreach (var perm in permissions)
//        {
//            // User role => only "View"
//            if (perm.Name.EndsWith(".View"))
//            {
//                roleAccesses.Add(new RoleAccess
//                {
//                    Id = Guid.NewGuid(),
//                    RoleId = userRoleId,
//                    PermissionId = perm.Id
//                });
//            }

//            // Admin role => allow View, Add, Edit
//            if (perm.Name.EndsWith(".View") ||
//                perm.Name.EndsWith(".Add") ||
//                perm.Name.EndsWith(".Edit"))
//            {
//                roleAccesses.Add(new RoleAccess
//                {
//                    Id = Guid.NewGuid(),
//                    RoleId = adminRoleId,
//                    PermissionId = perm.Id
//                });
//            }

//            // SuperAdmin role => allow ALL
//            roleAccesses.Add(new RoleAccess
//            {
//                Id = Guid.NewGuid(),
//                RoleId = superAdminRoleId,
//                PermissionId = perm.Id
//            });

//            counter++;
//        }

//        builder.Entity<RoleAccess>().HasData(roleAccesses);
//    }
//}


using CrmApi.Models;
using Microsoft.EntityFrameworkCore;

public static class RoleAccessSeeder
{
    public static void SeedRoleAccess(ModelBuilder builder)
    {
        // Role IDs (keep same as your existing seed)
        var userRoleId = "d03e3ed3-ab62-4d2e-a453-d9775d42b71d";
        var adminRoleId = "e74609f3-9db0-4b43-be0d-5d30155260b8";
        var superAdminRoleId = "586608ee-1036-4a17-8045-cae1b83d0bcc";

        // All permissions
        var permissions = PermissionSeeder.GetAllPermissions();

        // Define permission groups per role
        var userPermissions = permissions
            .Where(p => p.Name.EndsWith(".View"))
            .Select(p => p.Id)
            .ToList();

        var adminAllowedNames = new[]
        {
            // General CRUD modules
            "Leads.View", "Leads.Add", "Leads.Edit", "Leads.Export",
            "Deals.View", "Deals.Add", "Deals.Edit", "Deals.Export",
            "Contacts.View", "Contacts.Add", "Contacts.Edit", "Contacts.Export",
            "Companies.View", "Companies.Add", "Companies.Edit", "Companies.Export",
            "Users.View", "Users.Add", "Users.Edit",

            // Role management
            "RolePermissions.View", "RolePermissions.Manage",

            // Logs
            "AuditLogs.View",
            "AuditLogs.Request.View",
            "AuditLogs.Entity.View"
        };

        var adminPermissions = permissions
            .Where(p => adminAllowedNames.Contains(p.Name))
            .Select(p => p.Id)
            .ToList();

        var superAdminPermissions = permissions
            .Select(p => p.Id)
            .ToList();

        // Combine all RoleAccess entries
        var roleAccesses = new List<RoleAccess>();

        void AddAccess(string roleId, IEnumerable<Guid> permissionIds)
        {
            foreach (var pid in permissionIds)
            {
                roleAccesses.Add(new RoleAccess
                {
                    Id = Guid.NewGuid(),
                    RoleId = (roleId),
                    PermissionId = pid
                });
            }
        }

        AddAccess(userRoleId, userPermissions);
        AddAccess(adminRoleId, adminPermissions);
        AddAccess(superAdminRoleId, superAdminPermissions);

        builder.Entity<RoleAccess>().HasData(roleAccesses);
    }
}
