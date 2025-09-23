using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrmApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePermissionSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000021"));

            migrationBuilder.AddColumn<Guid>(
                name: "PermissionId1",
                table: "RoleAccesses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000006"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000007"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000010"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000011"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000012"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000014"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000015"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000016"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000006"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000007"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000008"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000009"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000010"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000011"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000012"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000013"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000014"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000015"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000016"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000017"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000018"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000019"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000020"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000021"),
                column: "PermissionId1",
                value: null);

            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "PermissionId", "PermissionId1", "RoleId" },
                values: new object[] { new Guid("4460be55-45fc-4725-8f75-1ef5875f6bba"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" });

            migrationBuilder.CreateIndex(
                name: "IX_RoleAccesses_PermissionId1",
                table: "RoleAccesses",
                column: "PermissionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccesses_Permissions_PermissionId1",
                table: "RoleAccesses",
                column: "PermissionId1",
                principalTable: "Permissions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccesses_Permissions_PermissionId1",
                table: "RoleAccesses");

            migrationBuilder.DropIndex(
                name: "IX_RoleAccesses_PermissionId1",
                table: "RoleAccesses");

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("4460be55-45fc-4725-8f75-1ef5875f6bba"));

            migrationBuilder.DropColumn(
                name: "PermissionId1",
                table: "RoleAccesses");

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("20000000-0000-0000-0000-000000000001"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000002"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000003"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000004"), new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000005"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000008"), new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000009"), new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000013"), new Guid("17817170-947b-4e96-9e11-192b2fbed308"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000017"), new Guid("62de43a8-2855-44ba-871e-40e938396df5"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000021"), new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"), "1e13facc-515f-40d1-8c0d-196a8374e104" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleId",
                table: "RolePermissions",
                column: "RoleId");
        }
    }
}
