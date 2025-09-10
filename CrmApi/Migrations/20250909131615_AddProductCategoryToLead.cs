using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrmApi.Migrations
{
    /// <inheritdoc />
    public partial class AddProductCategoryToLead : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "ProductCategory",
               table: "Leads",
               type: "nvarchar(max)",
               nullable: false,
               defaultValue: "Software");

            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Software License");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCategory",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Leads");

        }
    }
}
