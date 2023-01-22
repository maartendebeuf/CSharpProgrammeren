using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCKlas.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Familie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Orde = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Klasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilieScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dieren",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Benaming = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilieID = table.Column<int>(type: "int", nullable: false),
                    AantalPoten = table.Column<int>(type: "int", nullable: false),
                    Gevaarlijk = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dieren", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dieren_Familie_FamilieID",
                        column: x => x.FamilieID,
                        principalTable: "Familie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dieren_FamilieID",
                table: "Dieren",
                column: "FamilieID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dieren");

            migrationBuilder.DropTable(
                name: "Familie");
        }
    }
}
