using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MypizzeriaModel.Migrations
{
    /// <inheritdoc />
    public partial class Correzionetypos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "immagine",
                table: "Pizzas",
                newName: "Immagine");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Immagine",
                table: "Pizzas",
                newName: "immagine");
        }
    }
}
