using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrmApi.Migrations
{
    /// <inheritdoc />
    public partial class AddExportPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("016b17ed-6d5a-400a-b0cc-01c7712794e5"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("01ff3bf9-b068-4d33-92df-75708636fc6c"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("050d4414-9aa2-4e40-b5f8-411c3a4483ee"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("081688f4-d6f1-46e4-9207-9e292d60307a"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("0d69a703-9490-4ced-8abd-2fe126e22689"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("1381cf2c-9aef-4453-a6f1-b87a6a2aeb35"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("1815a175-1d9e-4d7f-a203-3141faa6b931"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20c3f0e7-f9fb-45e3-b066-227ed723c3fd"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("2236058c-6cd5-4e80-9b39-519d16776045"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("34371c61-388a-46bd-9ba0-ab9d16ccfebb"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("4b499600-dc27-42f5-9c87-19ee5f06085a"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("4e375b20-de23-4a44-b7ad-eb7cfc80131c"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("4ebc7cea-c6f4-4739-bc8b-db81120173a6"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("50281944-3c6c-49d0-a6b8-b1be2749c34d"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("50d672da-e2ef-4865-9c20-c05dd75f2087"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("5d0ea276-ca46-48de-82e0-984695826c8e"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("619bd0a3-a245-4147-bb01-9f8554822254"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("77ef3cee-dede-426d-9f3a-875d80683d20"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("796e56c2-7a2b-43df-a2ff-b80876756e4b"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7da2884f-bd4b-4b90-9eec-a61e1b0aae46"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("803a2ce9-cb46-4341-9496-e2073625bba7"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("8654ecfe-fe32-43d1-89e3-b9d3ae9ce84d"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("8da1407f-1d65-43a3-9686-b1e8b1c89f97"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("8edbdd47-615b-4e37-8f52-fd1b4b5767e1"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("9189793f-cbc2-4ff6-80bd-ed222590f09d"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("936004ed-f409-4b2d-9cbc-d82ca4883b62"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("93df2916-283a-4944-9881-485834a8275d"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("99ab7878-fbe9-470b-bdc3-84071d0ab89c"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a1d33dc3-96c3-4719-86b7-fb0326ce3210"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a296473d-4901-4c3f-8a29-6d71a1038d87"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a4d11e29-ecff-499e-9770-8682711367c2"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("aed6686f-869a-4429-93fd-28349e0ce08c"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("b5952451-8217-4746-b6fb-d132e79b5e83"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("b6d1c498-3959-4378-a26c-3b70daa163f8"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("bd981d84-b8df-438a-af0a-e814c769611e"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("c3a7a7e9-059c-4ac6-9e5d-789e98bfed90"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("cb7f52bf-459f-4e25-a73b-8195550ab4bb"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("ce603007-8b07-4f53-ab33-74771a4e70d0"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("d8e7ddce-6f30-4e51-a4a2-b3aa810d5a21"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("e7f97c93-9673-4b20-9209-c56978ff4074"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("f64b43ea-d5bb-4eb7-bf81-9fec636f7994"));

            migrationBuilder.DropColumn(
                name: "PermissionId1",
                table: "RoleAccesses");

            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("04594454-4b41-4c60-be51-7cbb13d7c89e"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("0a43adf5-453c-4a5a-95e0-0354e594e098"), new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("0a602246-251b-45a8-88ba-b766e6de06f5"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("0b24c7f9-54ee-40f5-af16-1b430136c1a5"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("0f83a7e5-6464-4748-90ff-acf84348e877"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("13d78e9f-4372-465a-ad62-6ffe81d72f54"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("1598cac8-e880-424f-a869-bb68ce6d2b29"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("175db50f-595f-4ffa-9e41-d1d270e06943"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("17ce169b-36f6-48c8-b0af-eb63912159db"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("181f11ca-eaf5-4aef-8f6a-73e00dc7d127"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("2c3d841f-3726-4c8e-842a-d8446231b15b"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("34a1fb01-7642-46d6-934d-6a36b9924d78"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("435aa48b-13f2-4951-881f-55e935e9aa25"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("44d42456-ca2f-4413-a7a7-13b1a1f5d3d5"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("4be36751-7b9b-48c9-b99f-2c74bee58034"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("4efe5fdb-e9ad-4b24-a5c5-d2bc140905b4"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("4f9c6b4d-8040-499a-99a2-2e59d99ff73b"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("54fb2a49-4a18-45b1-a6ef-0ee1f1c457eb"), new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("551e1212-accd-4812-913d-8ad7175a408f"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("57fc9d8c-15c1-4473-aa68-eade1d8b6197"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("58ac554f-9f10-499f-931f-09c3ff6ce45d"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("5976e57e-2c60-4968-b2f1-c9004f550c5a"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("778eb48d-92ac-4420-bdee-cd9333192ad0"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("7896dc5f-e278-4fe2-82f9-df9eca5e4af6"), new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("7ae51729-2779-4f52-9401-4c61b94d08cb"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("7fb097cb-6484-4664-87c8-e12b5e0bd83b"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("80586728-1868-4b36-8686-06e8dc2a7420"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("869bb9f7-af9f-42ad-bc61-f0f319355b9e"), new Guid("62de43a8-2855-44ba-871e-40e938396df5"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("8a95c579-b0b4-4625-a5ca-147e1ba92cd4"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("8becffcb-2e57-48c4-88ea-29e41faedd92"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("af4e371b-0dcf-4777-9873-b9b77db038ba"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("bc923df0-d756-4168-9195-3e10bc1061ec"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("c6c3f17d-b246-4d1c-b81f-32e68b6d3d78"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("cbdcc79d-05dd-4f98-b93c-4ae5ba4fdf78"), new Guid("17817170-947b-4e96-9e11-192b2fbed308"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("cfa44635-0898-45d5-95d5-ea6f9f6ef91c"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("d8445a01-ddca-4634-96ba-b5cc2b8f65ed"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("dbefaa9e-ab64-4742-b05f-d0973e910d3f"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("e2ca8531-6da5-438d-8bae-70eeee8649c1"), new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("e76d9b6a-3ad7-4cd1-964f-c3af4718475d"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("ee1476c5-d202-4fe5-b41c-d49c292068a2"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("feab715f-f92f-4d75-b851-ba40161c0797"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), "38e3e873-009f-4765-bfab-e58b39f12c64" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("04594454-4b41-4c60-be51-7cbb13d7c89e"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("0a43adf5-453c-4a5a-95e0-0354e594e098"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("0a602246-251b-45a8-88ba-b766e6de06f5"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("0b24c7f9-54ee-40f5-af16-1b430136c1a5"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("0f83a7e5-6464-4748-90ff-acf84348e877"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("13d78e9f-4372-465a-ad62-6ffe81d72f54"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("1598cac8-e880-424f-a869-bb68ce6d2b29"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("175db50f-595f-4ffa-9e41-d1d270e06943"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("17ce169b-36f6-48c8-b0af-eb63912159db"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("181f11ca-eaf5-4aef-8f6a-73e00dc7d127"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("2c3d841f-3726-4c8e-842a-d8446231b15b"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("34a1fb01-7642-46d6-934d-6a36b9924d78"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("435aa48b-13f2-4951-881f-55e935e9aa25"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("44d42456-ca2f-4413-a7a7-13b1a1f5d3d5"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("4be36751-7b9b-48c9-b99f-2c74bee58034"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("4efe5fdb-e9ad-4b24-a5c5-d2bc140905b4"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("4f9c6b4d-8040-499a-99a2-2e59d99ff73b"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("54fb2a49-4a18-45b1-a6ef-0ee1f1c457eb"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("551e1212-accd-4812-913d-8ad7175a408f"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("57fc9d8c-15c1-4473-aa68-eade1d8b6197"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("58ac554f-9f10-499f-931f-09c3ff6ce45d"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("5976e57e-2c60-4968-b2f1-c9004f550c5a"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("778eb48d-92ac-4420-bdee-cd9333192ad0"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7896dc5f-e278-4fe2-82f9-df9eca5e4af6"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7ae51729-2779-4f52-9401-4c61b94d08cb"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7fb097cb-6484-4664-87c8-e12b5e0bd83b"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("80586728-1868-4b36-8686-06e8dc2a7420"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("869bb9f7-af9f-42ad-bc61-f0f319355b9e"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("8a95c579-b0b4-4625-a5ca-147e1ba92cd4"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("8becffcb-2e57-48c4-88ea-29e41faedd92"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("af4e371b-0dcf-4777-9873-b9b77db038ba"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("bc923df0-d756-4168-9195-3e10bc1061ec"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("c6c3f17d-b246-4d1c-b81f-32e68b6d3d78"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("cbdcc79d-05dd-4f98-b93c-4ae5ba4fdf78"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("cfa44635-0898-45d5-95d5-ea6f9f6ef91c"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("d8445a01-ddca-4634-96ba-b5cc2b8f65ed"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("dbefaa9e-ab64-4742-b05f-d0973e910d3f"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("e2ca8531-6da5-438d-8bae-70eeee8649c1"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("e76d9b6a-3ad7-4cd1-964f-c3af4718475d"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("ee1476c5-d202-4fe5-b41c-d49c292068a2"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("feab715f-f92f-4d75-b851-ba40161c0797"));

            migrationBuilder.AddColumn<Guid>(
                name: "PermissionId1",
                table: "RoleAccesses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "PermissionId", "PermissionId1", "RoleId" },
                values: new object[,]
                {
                    { new Guid("016b17ed-6d5a-400a-b0cc-01c7712794e5"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("01ff3bf9-b068-4d33-92df-75708636fc6c"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), null, "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("050d4414-9aa2-4e40-b5f8-411c3a4483ee"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("081688f4-d6f1-46e4-9207-9e292d60307a"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("0d69a703-9490-4ced-8abd-2fe126e22689"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("1381cf2c-9aef-4453-a6f1-b87a6a2aeb35"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("1815a175-1d9e-4d7f-a203-3141faa6b931"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20c3f0e7-f9fb-45e3-b066-227ed723c3fd"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("2236058c-6cd5-4e80-9b39-519d16776045"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("34371c61-388a-46bd-9ba0-ab9d16ccfebb"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("4b499600-dc27-42f5-9c87-19ee5f06085a"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("4e375b20-de23-4a44-b7ad-eb7cfc80131c"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), null, "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("4ebc7cea-c6f4-4739-bc8b-db81120173a6"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("50281944-3c6c-49d0-a6b8-b1be2749c34d"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("50d672da-e2ef-4865-9c20-c05dd75f2087"), new Guid("17817170-947b-4e96-9e11-192b2fbed308"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("5d0ea276-ca46-48de-82e0-984695826c8e"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("619bd0a3-a245-4147-bb01-9f8554822254"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), null, "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("77ef3cee-dede-426d-9f3a-875d80683d20"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("796e56c2-7a2b-43df-a2ff-b80876756e4b"), new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("7da2884f-bd4b-4b90-9eec-a61e1b0aae46"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("803a2ce9-cb46-4341-9496-e2073625bba7"), new Guid("62de43a8-2855-44ba-871e-40e938396df5"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("8654ecfe-fe32-43d1-89e3-b9d3ae9ce84d"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("8da1407f-1d65-43a3-9686-b1e8b1c89f97"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("8edbdd47-615b-4e37-8f52-fd1b4b5767e1"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), null, "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("9189793f-cbc2-4ff6-80bd-ed222590f09d"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("936004ed-f409-4b2d-9cbc-d82ca4883b62"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("93df2916-283a-4944-9881-485834a8275d"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("99ab7878-fbe9-470b-bdc3-84071d0ab89c"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("a1d33dc3-96c3-4719-86b7-fb0326ce3210"), new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("a296473d-4901-4c3f-8a29-6d71a1038d87"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("a4d11e29-ecff-499e-9770-8682711367c2"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("aed6686f-869a-4429-93fd-28349e0ce08c"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("b5952451-8217-4746-b6fb-d132e79b5e83"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("b6d1c498-3959-4378-a26c-3b70daa163f8"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("bd981d84-b8df-438a-af0a-e814c769611e"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("c3a7a7e9-059c-4ac6-9e5d-789e98bfed90"), new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("cb7f52bf-459f-4e25-a73b-8195550ab4bb"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("ce603007-8b07-4f53-ab33-74771a4e70d0"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), null, "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("d8e7ddce-6f30-4e51-a4a2-b3aa810d5a21"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("e7f97c93-9673-4b20-9209-c56978ff4074"), new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("f64b43ea-d5bb-4eb7-bf81-9fec636f7994"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" }
                });

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
    }
}
