using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrmApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedPermissionsAndRoleAccess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleAccesses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAccesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleAccesses_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleAccesses_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "Edit companies", "Companies.Edit" },
                    { new Guid("17817170-947b-4e96-9e11-192b2fbed308"), "Delete deals", "Deals.Delete" },
                    { new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"), "Delete users", "Users.Delete" },
                    { new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), "Add contacts", "Contacts.Add" },
                    { new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "Add users", "Users.Add" },
                    { new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), "Edit deals", "Deals.Edit" },
                    { new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "View contacts", "Contacts.View" },
                    { new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "View deals", "Deals.View" },
                    { new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), "Add companies", "Companies.Add" },
                    { new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"), "Export leads", "Leads.Export" },
                    { new Guid("62de43a8-2855-44ba-871e-40e938396df5"), "Delete contacts", "Contacts.Delete" },
                    { new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), "Edit leads", "Leads.Edit" },
                    { new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"), "Delete leads", "Leads.Delete" },
                    { new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "View users", "Users.View" },
                    { new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"), "Delete companies", "Companies.Delete" },
                    { new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "View companies", "Companies.View" },
                    { new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "Edit users", "Users.Edit" },
                    { new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "Add leads", "Leads.Add" },
                    { new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "View leads", "Leads.View" },
                    { new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), "Add deals", "Deals.Add" },
                    { new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), "Edit contacts", "Contacts.Edit" }
                });

            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("10000000-0000-0000-0000-000000000004"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("10000000-0000-0000-0000-000000000005"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("20000000-0000-0000-0000-000000000001"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000002"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000003"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000004"), new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000005"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000006"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000007"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000008"), new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000009"), new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000010"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000011"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000012"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000013"), new Guid("17817170-947b-4e96-9e11-192b2fbed308"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000014"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000015"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000016"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000017"), new Guid("62de43a8-2855-44ba-871e-40e938396df5"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000018"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000019"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000020"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000021"), new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("30000000-0000-0000-0000-000000000001"), new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000002"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000003"), new Guid("17817170-947b-4e96-9e11-192b2fbed308"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000004"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000005"), new Guid("62de43a8-2855-44ba-871e-40e938396df5"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000006"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000007"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000008"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000009"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000010"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000011"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000012"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000013"), new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000014"), new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000015"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000016"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000017"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000018"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000019"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000020"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000021"), new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"), "38e3e873-009f-4765-bfab-e58b39f12c64" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleAccesses_PermissionId",
                table: "RoleAccesses",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAccesses_RoleId",
                table: "RoleAccesses",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleAccesses");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("17817170-947b-4e96-9e11-192b2fbed308"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("62de43a8-2855-44ba-871e-40e938396df5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"));
        }
    }
}
