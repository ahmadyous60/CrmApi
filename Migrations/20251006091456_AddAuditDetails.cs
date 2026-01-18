using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrmApi.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangedColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endpoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("00127a94-3715-4c20-ac90-619b22821996"), new Guid("98bcfa90-8de9-499e-9455-aab4087d8c8a"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("1317c5b7-d0a3-4074-8e0e-b9c09aab5fea"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("17cf9f93-941e-40ec-a17e-8c5d49bb624f"), new Guid("fd4af3cb-df9f-4307-8727-b77b10982e46"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("1b1c3311-f658-4b68-8fef-4ea1b73ae235"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("1c95016b-2d72-4d9f-95ad-5622e814c233"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("20416c10-d299-4d66-a448-d8380e9a5544"), new Guid("82e99d1d-5da6-4540-bfe1-0d9b4e8278bb"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("306243cb-b4e6-490d-abe3-050cfc94eb82"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("336e5e57-6b0d-4563-8ea5-fcf133173504"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("36b0868a-dc23-4b4e-8f31-15c14ae8f848"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("3c12fa6c-e477-4eb3-bb9c-dc2f356168ff"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("3cf41cf6-7f82-41c4-bfc9-730601aa1a3f"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("40ddab1b-5ac9-42fe-a17f-5a0f186ef8ad"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("413d0667-fcf5-4cf0-8435-ba73e3a3b59a"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("45e5cced-dc2c-47a4-93b3-d7e4bfb9cbe1"), new Guid("62de43a8-2855-44ba-871e-40e938396df5"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("4f2d50b0-8f9a-4deb-8f9e-dfe12fd1f5ef"), new Guid("25d79875-6cbb-49dc-9fa0-f7fd1a5ef611"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("50c1e990-9d42-4c93-bb5f-ec31813f08e5"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("52098bf6-6d5f-4385-9ca9-0a49dcdb341b"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("585302ce-2cf0-419d-b1eb-2fdf54287670"), new Guid("17817170-947b-4e96-9e11-192b2fbed308"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("6a0929d7-acb9-437a-90e1-0810b3bc5492"), new Guid("5ce44f6d-bc61-4e5d-9e25-1af9304d65c9"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("6a91b620-4d34-44e5-9e0c-cc3cf09140eb"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("6d7f6a3c-759b-4d4d-9516-7b707dc70dc9"), new Guid("acd36735-5f59-4f12-bc1a-08b7a2da6781"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("6effc200-2bbf-4037-8941-1431825c72f7"), new Guid("ea2a225b-01fb-4a95-a42b-6814a478b91d"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("72c90b53-9b6e-4066-bbe0-4443dc31af2c"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("7a70f182-2591-4bb1-baf9-72ec333dbf51"), new Guid("619e7d84-a439-496f-81c0-b4a979af3c66"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("7c953ce5-157b-4539-b5fe-21cbe1837880"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("7d7c4b42-71c6-4158-afb7-cc375267c72a"), new Guid("b6c53f41-0129-4ee0-9c4f-37f7886acd12"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("8e166118-61de-47e2-8086-38a989509670"), new Guid("504672a9-2f7f-4480-9d06-4826a6de01d5"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("a26776f5-e613-42a2-8260-1f3ce2bc1efc"), new Guid("61ebea0b-5e99-445f-94dc-f90b6a62d631"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("a45665ae-0ca1-4760-b4ce-4e697eb028f7"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("aa2183eb-d583-4b9f-b45c-04809e0281e9"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("aa4225fc-fe5f-4759-a214-307a0ae1851e"), new Guid("befb6f03-7c95-4ffe-85f1-59be64958175"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("afaf24fd-ecb2-46ae-9ca1-73b5503b465c"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("b4677495-f6bc-46a6-8078-6ee8c5fd3879"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("b9634b20-4a67-410f-928d-a76207ece185"), new Guid("197de633-9f35-4da3-a20f-77d08f9843ab"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("bea3e216-c64b-4af8-a705-e49e77d5c26c"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("c7073cc5-9390-413a-9a1a-1cb95f244676"), new Guid("7aa1fd07-7726-414e-9dce-1723586c128e"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("ce50665a-5fb3-4f9f-ad06-da730532e9a0"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("d5d784f2-c59c-4aa9-a7f2-521e0909eeea"), new Guid("185b4989-d80d-4bbc-9cc2-aafc1d05f7ed"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("e83ec7b2-f6ab-4dd1-aaec-18878d480825"), new Guid("e2f7c163-e7e8-49f7-9dd0-25662363524e"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("ebc239b2-2f6c-4e5a-9541-81820bce10de"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("f1342aa8-86f1-4a74-8533-dc2ee20c0e23"), new Guid("1b6fb93e-6e53-4385-b284-d72e1ac92873"), "1e13facc-515f-40d1-8c0d-196a8374e104" },
                    { new Guid("fbe75c87-99f0-482b-8902-c20aa994902e"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("fef91192-004b-4339-9328-3b7093d81bb2"), new Guid("926e654e-7c2b-4c24-8c12-7a594a4008e0"), "ab6ef452-b89e-4382-9cb7-a2f9ae074e5a" },
                    { new Guid("ff015369-4ec8-4cc3-ac27-6854ec570a4c"), new Guid("d4a75f2b-e9f1-4bf7-8713-4149f1c05d71"), "1e13facc-515f-40d1-8c0d-196a8374e104" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("00127a94-3715-4c20-ac90-619b22821996"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("1317c5b7-d0a3-4074-8e0e-b9c09aab5fea"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("17cf9f93-941e-40ec-a17e-8c5d49bb624f"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("1b1c3311-f658-4b68-8fef-4ea1b73ae235"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("1c95016b-2d72-4d9f-95ad-5622e814c233"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("20416c10-d299-4d66-a448-d8380e9a5544"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("306243cb-b4e6-490d-abe3-050cfc94eb82"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("336e5e57-6b0d-4563-8ea5-fcf133173504"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("36b0868a-dc23-4b4e-8f31-15c14ae8f848"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("3c12fa6c-e477-4eb3-bb9c-dc2f356168ff"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("3cf41cf6-7f82-41c4-bfc9-730601aa1a3f"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("40ddab1b-5ac9-42fe-a17f-5a0f186ef8ad"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("413d0667-fcf5-4cf0-8435-ba73e3a3b59a"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("45e5cced-dc2c-47a4-93b3-d7e4bfb9cbe1"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("4f2d50b0-8f9a-4deb-8f9e-dfe12fd1f5ef"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("50c1e990-9d42-4c93-bb5f-ec31813f08e5"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("52098bf6-6d5f-4385-9ca9-0a49dcdb341b"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("585302ce-2cf0-419d-b1eb-2fdf54287670"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("6a0929d7-acb9-437a-90e1-0810b3bc5492"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("6a91b620-4d34-44e5-9e0c-cc3cf09140eb"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("6d7f6a3c-759b-4d4d-9516-7b707dc70dc9"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("6effc200-2bbf-4037-8941-1431825c72f7"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("72c90b53-9b6e-4066-bbe0-4443dc31af2c"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7a70f182-2591-4bb1-baf9-72ec333dbf51"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7c953ce5-157b-4539-b5fe-21cbe1837880"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("7d7c4b42-71c6-4158-afb7-cc375267c72a"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("8e166118-61de-47e2-8086-38a989509670"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a26776f5-e613-42a2-8260-1f3ce2bc1efc"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("a45665ae-0ca1-4760-b4ce-4e697eb028f7"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("aa2183eb-d583-4b9f-b45c-04809e0281e9"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("aa4225fc-fe5f-4759-a214-307a0ae1851e"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("afaf24fd-ecb2-46ae-9ca1-73b5503b465c"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("b4677495-f6bc-46a6-8078-6ee8c5fd3879"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("b9634b20-4a67-410f-928d-a76207ece185"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("bea3e216-c64b-4af8-a705-e49e77d5c26c"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("c7073cc5-9390-413a-9a1a-1cb95f244676"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("ce50665a-5fb3-4f9f-ad06-da730532e9a0"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("d5d784f2-c59c-4aa9-a7f2-521e0909eeea"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("e83ec7b2-f6ab-4dd1-aaec-18878d480825"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("ebc239b2-2f6c-4e5a-9541-81820bce10de"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("f1342aa8-86f1-4a74-8533-dc2ee20c0e23"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("fbe75c87-99f0-482b-8902-c20aa994902e"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("fef91192-004b-4339-9328-3b7093d81bb2"));

            migrationBuilder.DeleteData(
                table: "RoleAccesses",
                keyColumn: "Id",
                keyValue: new Guid("ff015369-4ec8-4cc3-ac27-6854ec570a4c"));

            migrationBuilder.InsertData(
                table: "RoleAccesses",
                columns: new[] { "Id", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("020d1c7e-ec15-490f-bd6a-6ce59877d349"), new Guid("454f0f6a-a216-45ab-b78b-d2079cb4d608"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("0584436f-6a0c-4633-bb7c-24a3ecde99ee"), new Guid("b6c53f41-0129-4ee0-9c4f-37f7886acd12"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("09803c84-6507-493d-947e-374c0d703b6a"), new Guid("e2e6f8ce-176f-4599-b92e-dcc5fb3050cb"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
                    { new Guid("0a2dce56-6ef6-4fec-b180-a881bf52f7aa"), new Guid("acd36735-5f59-4f12-bc1a-08b7a2da6781"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
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
                    { new Guid("aabba0fd-355b-4486-9a6b-23748271a77b"), new Guid("5ce44f6d-bc61-4e5d-9e25-1af9304d65c9"), "38e3e873-009f-4765-bfab-e58b39f12c64" },
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
                    { new Guid("feade588-4d1f-42d0-90ec-ec3d7dd7f026"), new Guid("0e29daf9-7fac-4fc8-9532-4e499e4afde7"), "38e3e873-009f-4765-bfab-e58b39f12c64" }
                });
        }
    }
}
