using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class SpecificationValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecificationValues",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SpecificationId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificationValues", x => new { x.ProductId, x.SpecificationId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecificationValues");
        }
    }
}
