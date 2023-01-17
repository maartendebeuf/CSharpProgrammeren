using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCKlas.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDierenarts3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dierenarts_Families_FamilieID",
                table: "Dierenarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dierenarts",
                table: "Dierenarts");

            migrationBuilder.RenameTable(
                name: "Dierenarts",
                newName: "Dierenartsen");

            migrationBuilder.RenameIndex(
                name: "IX_Dierenarts_FamilieID",
                table: "Dierenartsen",
                newName: "IX_Dierenartsen_FamilieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dierenartsen",
                table: "Dierenartsen",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dierenartsen_Families_FamilieID",
                table: "Dierenartsen",
                column: "FamilieID",
                principalTable: "Families",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dierenartsen_Families_FamilieID",
                table: "Dierenartsen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dierenartsen",
                table: "Dierenartsen");

            migrationBuilder.RenameTable(
                name: "Dierenartsen",
                newName: "Dierenarts");

            migrationBuilder.RenameIndex(
                name: "IX_Dierenartsen_FamilieID",
                table: "Dierenarts",
                newName: "IX_Dierenarts_FamilieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dierenarts",
                table: "Dierenarts",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dierenarts_Families_FamilieID",
                table: "Dierenarts",
                column: "FamilieID",
                principalTable: "Families",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
