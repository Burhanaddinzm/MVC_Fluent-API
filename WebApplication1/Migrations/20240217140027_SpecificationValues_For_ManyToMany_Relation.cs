using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class SpecificationValues_For_ManyToMany_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SpecificationValues_SpecificationId",
                table: "SpecificationValues",
                column: "SpecificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificationValues_Products_ProductId",
                table: "SpecificationValues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificationValues_Specifications_SpecificationId",
                table: "SpecificationValues",
                column: "SpecificationId",
                principalTable: "Specifications",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecificationValues_Products_ProductId",
                table: "SpecificationValues");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificationValues_Specifications_SpecificationId",
                table: "SpecificationValues");

            migrationBuilder.DropIndex(
                name: "IX_SpecificationValues_SpecificationId",
                table: "SpecificationValues");
        }
    }
}
