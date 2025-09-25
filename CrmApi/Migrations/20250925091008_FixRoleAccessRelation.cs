using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrmApi.Migrations
{
    /// <inheritdoc />
    public partial class FixRoleAccessRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("4460be55-45fc-4725-8f75-1ef5875f6bba"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "PermissionId", "PermissionId1", "RoleId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000004"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), null, "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("10000000-0000-0000-0000-000000000005"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), null, "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("20000000-0000-0000-0000-000000000006"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000007"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000010"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000011"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000012"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000014"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000015"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000016"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000018"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000019"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("20000000-0000-0000-0000-000000000020"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("30000000-0000-0000-0000-000000000001"), new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000002"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000003"), new Guid("17817170-947b-4e96-9e11-192b2fbed308"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000004"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000005"), new Guid("62de43a8-2855-44ba-871e-40e938396df5"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000006"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000007"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000008"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000009"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000010"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000011"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000012"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000013"), new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000014"), new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000015"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000016"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000017"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000018"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000019"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000020"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("30000000-0000-0000-0000-000000000021"), new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"), null, "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("4460be55-45fc-4725-8f75-1ef5875f6bba"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), null, "1e13facc-515f-40d1-8c0d-196a8374e104" }
                });
        }
    }
}
