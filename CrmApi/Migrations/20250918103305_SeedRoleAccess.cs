using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrmApi.Migrations
{
    public partial class SeedRoleAccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // ================= USER (View-only) =================
            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "RoleId", "PermissionId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a", new Guid("926E654E-7C2B-4C24-8C12-7A594A4008E0") }, // Users.View
                    { new Guid("10000000-0000-0000-0000-000000000002"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a", new Guid("E2F7C163-E7E8-49F7-9DD0-25662363524E") }, // Leads.View
                    { new Guid("10000000-0000-0000-0000-000000000003"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a", new Guid("504672A9-2F7F-4480-9D06-4826A6DE01D5") }, // Deals.View
                    { new Guid("10000000-0000-0000-0000-000000000004"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a", new Guid("454F0F6A-A216-45AB-B78B-D2079CB4D608") }, // Contacts.View
                    { new Guid("10000000-0000-0000-0000-000000000005"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a", new Guid("BEFB6F03-7C95-4FFE-85F1-59BE64958175") }  // Companies.View
                });

            // ================= ADMIN (CRUD) =================
            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "RoleId", "PermissionId" },
                values: new object[,]
                {
                    // Leads
                    { new Guid("20000000-0000-0000-0000-000000000005"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("E2F7C163-E7E8-49F7-9DD0-25662363524E") },
                    { new Guid("20000000-0000-0000-0000-000000000006"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("E2E6F8CE-176F-4599-B92E-DCC5FB3050CB") },
                    { new Guid("20000000-0000-0000-0000-000000000007"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("7AA1FD07-7726-414E-9DCE-1723586C128E") },

                    // Deals
                    { new Guid("20000000-0000-0000-0000-000000000010"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("504672A9-2F7F-4480-9D06-4826A6DE01D5") },
                    { new Guid("20000000-0000-0000-0000-000000000011"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("EA2A225B-01FB-4A95-A42B-6814A478B91D") },
                    { new Guid("20000000-0000-0000-0000-000000000012"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("25D79875-6CBB-49DC-9FA0-F7FD1A5EF611") },

                    // Contacts
                    { new Guid("20000000-0000-0000-0000-000000000014"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("454F0F6A-A216-45AB-B78B-D2079CB4D608") },
                    { new Guid("20000000-0000-0000-0000-000000000015"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("197DE633-9F35-4DA3-A20F-77D08F9843AB") },
                    { new Guid("20000000-0000-0000-0000-000000000016"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("FD4AF3CB-DF9F-4307-8727-B77B10982E46") },

                    // Companies
                    { new Guid("20000000-0000-0000-0000-000000000018"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("BEFB6F03-7C95-4FFE-85F1-59BE64958175") },
                    { new Guid("20000000-0000-0000-0000-000000000019"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("619E7D84-A439-496F-81C0-B4A979AF3C66") },
                    { new Guid("20000000-0000-0000-0000-000000000020"), "1e13facc-515f-40d1-8c0d-196a8374e104", new Guid("0E29DAF9-7FAC-4FC8-9532-4E499E4AFDE7") }
                });

            // ================= SUPERADMIN (ALL) =================
            string[] allPermissions = new[]
            {
                "82E99D1D-5DA6-4540-BFE1-0D9B4E8278BB","7AA1FD07-7726-414E-9DCE-1723586C128E","17817170-947B-4E96-9E11-192B2FBED308",
                "E2F7C163-E7E8-49F7-9DD0-25662363524E","62DE43A8-2855-44BA-871E-40E938396DF5","D4A75F2B-E9F1-4BF7-8713-4149F1C05D71",
                "504672A9-2F7F-4480-9D06-4826A6DE01D5","0E29DAF9-7FAC-4FC8-9532-4E499E4AFDE7","BEFB6F03-7C95-4FFE-85F1-59BE64958175",
                "EA2A225B-01FB-4A95-A42B-6814A478B91D","197DE633-9F35-4DA3-A20F-77D08F9843AB","926E654E-7C2B-4C24-8C12-7A594A4008E0",
                "98BCFA90-8DE9-499E-9455-AAB4087D8C8A","185B4989-D80D-4BBC-9CC2-AAFC1D05F7ED","619E7D84-A439-496F-81C0-B4A979AF3C66",
                "FD4AF3CB-DF9F-4307-8727-B77B10982E46","454F0F6A-A216-45AB-B78B-D2079CB4D608","1B6FB93E-6E53-4385-B284-D72E1AC92873",
                "E2E6F8CE-176F-4599-B92E-DCC5FB3050CB","25D79875-6CBB-49DC-9FA0-F7FD1A5EF611","61EBEA0B-5E99-445F-94DC-F90B6A62D631"
            };

            int counter = 1;
            foreach (var permId in allPermissions)
            {
                migrationBuilder.InsertData(
                    table: "RoleAccesses",
                    columns: new[] { "Id", "RoleId", "PermissionId" },
                    values: new object[]
                    {
                        Guid.Parse($"30000000-0000-0000-0000-{counter.ToString("D12")}"),
                        "38e3e873-009f-4765-bfab-e58b39f12c64",
                        Guid.Parse(permId)
                    }
                );
                counter++;
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Delete USER and ADMIN
            for (int i = 1; i <= 5; i++)
            {
                migrationBuilder.DeleteData("RoleAccesses", "Id", Guid.Parse($"10000000-0000-0000-0000-{i.ToString("D12")}"));
            }

            int[] adminIds = { 5, 6, 7, 10, 11, 12, 14, 15, 16, 18, 19, 20 };
            foreach (var id in adminIds)
            {
                migrationBuilder.DeleteData("RoleAccesses", "Id", Guid.Parse($"20000000-0000-0000-0000-{id.ToString("D12")}"));
            }

            // Delete SUPERADMIN
            for (int i = 1; i <= 20; i++)
            {
                migrationBuilder.DeleteData("RoleAccesses", "Id", Guid.Parse($"30000000-0000-0000-0000-{i.ToString("D12")}"));
            }
        }
    }
}
