using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrmApi.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditLogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("5ce44f6d-bc61-4e5d-9e25-1af9304d65c9"), "Export companies", "Companies.Export" },
                    { new Guid("acd36735-5f59-4f12-bc1a-08b7a2da6781"), "Export deals", "Deals.Export" },
                    { new Guid("b6c53f41-0129-4ee0-9c4f-37f7886acd12"), "Export contacts", "Contacts.Export" }
                });

            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("020d1c7e-ec15-490f-bd6a-6ce59877d349"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("09803c84-6507-493d-947e-374c0d703b6a"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("0c010d7e-83d9-4f22-863e-5e9fca242f1b"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("0fce7072-0799-43fc-a982-9570cf7b93c9"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("264fe318-5738-4756-be7c-be85cfc8fa00"), new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("2b06426d-6a4e-4040-9338-037829536110"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("2ddb0d0c-f646-408f-87db-25b222ecf9c9"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("3bfe62e2-aece-4bf3-b2d2-22e44c45ff1b"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("3c2e4d33-1031-48c9-950a-42e0b6be4d33"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("509c6e06-4f80-425d-b5e8-153bc494f37c"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("5b60e0bb-22be-47a7-b685-1e3cc89224a5"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("5d61f931-7c81-40e1-8ffa-15232663f47f"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("60778a76-f969-4ba0-97b4-44995decda28"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("6c86e5cb-8497-40a2-8aea-7dfc8f0a318d"), new Guid("62de43a8-2855-44ba-871e-40e938396df5"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("71d28a10-17b3-4977-9b27-642455a94d63"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("7246b446-50da-4151-858e-864a75e7a0cf"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("74789838-d061-4157-97c1-39e68dd42e72"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("74b874a3-66b9-46e0-a3e3-43c35748ceff"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("7e06d40e-cd78-4fc3-a20b-b1f9b13c4e45"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("7ed6c911-6bb6-4032-904c-792151e5fbe8"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("8461068d-34d9-44ff-8555-c56e44445e87"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("8b32cd62-5028-4273-af17-610015a71be9"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("8e0c8e89-0982-409e-8493-29d9f256b6b0"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("9721f35b-a858-4a2f-807e-9047264bb2a8"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("a109504f-152c-4e55-a931-7ef9557e896b"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("a15ca3c5-c02b-4017-9e16-c821e88ce7ec"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("a65bb4da-d112-4b8d-82be-a39473b5c86a"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("a7581135-8ab2-4d07-b728-232a0d1cae48"), new Guid("17817170-947b-4e96-9e11-192b2fbed308"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("a970719a-950e-4cc7-9edc-c1981f041169"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("af5deb5d-346e-4750-8238-7fc6975b5f36"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("bb4dc866-bfc1-48d2-afcf-f29a0566ff6d"), new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("bc5f7bf8-565d-46b8-862c-3107a06b9023"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("c129237a-cecc-435c-991d-d1706bcdf40f"), new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("cca09287-e330-41ce-88c8-217c2c2c66c4"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("d1c5530b-6af2-4192-83f8-918a55f7f7e6"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("e70844e0-9f70-4dfa-acb0-749f531d5ef4"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("e77a1692-947b-4902-9c27-3600966f0356"), new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("ec9b7c3d-1f33-4e41-be15-dff12e09e400"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("f5a9d3d5-d9b2-4495-9e20-56f20e81e969"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("f770f421-0beb-4cfe-a4b2-4f7dbbc155fe"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("feade588-4d1f-42d0-90ec-ec3d7dd7f026"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("0584436f-6a0c-4633-bb7c-24a3ecde99ee"), new Guid("b6c53f41-0129-4ee0-9c4f-37f7886acd12"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("0a2dce56-6ef6-4fec-b180-a881bf52f7aa"), new Guid("acd36735-5f59-4f12-bc1a-08b7a2da6781"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("aabba0fd-355b-4486-9a6b-23748271a77b"), new Guid("5ce44f6d-bc61-4e5d-9e25-1af9304d65c9"), "38e3e873-009f-4765-bfab-e58b39f12c64" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("020d1c7e-ec15-490f-bd6a-6ce59877d349"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("0584436f-6a0c-4633-bb7c-24a3ecde99ee"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("09803c84-6507-493d-947e-374c0d703b6a"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("0a2dce56-6ef6-4fec-b180-a881bf52f7aa"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("0c010d7e-83d9-4f22-863e-5e9fca242f1b"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("0fce7072-0799-43fc-a982-9570cf7b93c9"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("264fe318-5738-4756-be7c-be85cfc8fa00"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("2b06426d-6a4e-4040-9338-037829536110"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("2ddb0d0c-f646-408f-87db-25b222ecf9c9"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("3bfe62e2-aece-4bf3-b2d2-22e44c45ff1b"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("3c2e4d33-1031-48c9-950a-42e0b6be4d33"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("509c6e06-4f80-425d-b5e8-153bc494f37c"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("5b60e0bb-22be-47a7-b685-1e3cc89224a5"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("5d61f931-7c81-40e1-8ffa-15232663f47f"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("60778a76-f969-4ba0-97b4-44995decda28"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("6c86e5cb-8497-40a2-8aea-7dfc8f0a318d"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("71d28a10-17b3-4977-9b27-642455a94d63"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7246b446-50da-4151-858e-864a75e7a0cf"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("74789838-d061-4157-97c1-39e68dd42e72"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("74b874a3-66b9-46e0-a3e3-43c35748ceff"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7e06d40e-cd78-4fc3-a20b-b1f9b13c4e45"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7ed6c911-6bb6-4032-904c-792151e5fbe8"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("8461068d-34d9-44ff-8555-c56e44445e87"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("8b32cd62-5028-4273-af17-610015a71be9"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("8e0c8e89-0982-409e-8493-29d9f256b6b0"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("9721f35b-a858-4a2f-807e-9047264bb2a8"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a109504f-152c-4e55-a931-7ef9557e896b"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a15ca3c5-c02b-4017-9e16-c821e88ce7ec"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a65bb4da-d112-4b8d-82be-a39473b5c86a"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a7581135-8ab2-4d07-b728-232a0d1cae48"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a970719a-950e-4cc7-9edc-c1981f041169"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("aabba0fd-355b-4486-9a6b-23748271a77b"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("af5deb5d-346e-4750-8238-7fc6975b5f36"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("bb4dc866-bfc1-48d2-afcf-f29a0566ff6d"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("bc5f7bf8-565d-46b8-862c-3107a06b9023"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("c129237a-cecc-435c-991d-d1706bcdf40f"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("cca09287-e330-41ce-88c8-217c2c2c66c4"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("d1c5530b-6af2-4192-83f8-918a55f7f7e6"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("e70844e0-9f70-4dfa-acb0-749f531d5ef4"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("e77a1692-947b-4902-9c27-3600966f0356"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("ec9b7c3d-1f33-4e41-be15-dff12e09e400"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("f5a9d3d5-d9b2-4495-9e20-56f20e81e969"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("f770f421-0beb-4cfe-a4b2-4f7dbbc155fe"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("feade588-4d1f-42d0-90ec-ec3d7dd7f026"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5ce44f6d-bc61-4e5d-9e25-1af9304d65c9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("acd36735-5f59-4f12-bc1a-08b7a2da6781"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b6c53f41-0129-4ee0-9c4f-37f7886acd12"));

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
    }
}
