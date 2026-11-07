using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sharpness_sharp.Migrations
{
    /// <inheritdoc />
    public partial class AddTablaCafes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cafes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imagen = table.Column<string>(type: "TEXT", nullable: false),
                    NombreCafe = table.Column<string>(type: "TEXT", nullable: false),
                    DescripcionCafe = table.Column<string>(type: "TEXT", nullable: false),
                    PrecioCafe = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cafes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cafes");
        }
    }
}
