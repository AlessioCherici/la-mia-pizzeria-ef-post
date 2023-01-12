using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MypizzeriaModel.Migrations
{
    /// <inheritdoc />
    public partial class Aggiuntomodelpizzas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "immagine",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "immagine",
                table: "Pizzas");
        }
    }
}
