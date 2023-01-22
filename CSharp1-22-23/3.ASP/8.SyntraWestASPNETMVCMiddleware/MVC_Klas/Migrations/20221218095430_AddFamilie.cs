using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCKlas.Migrations
{
    /// <inheritdoc />
    public partial class AddFamilie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dieren_Familie_FamilieID",
                table: "Dieren");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Familie",
                table: "Familie");

            migrationBuilder.RenameTable(
                name: "Familie",
                newName: "Families");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Families",
                table: "Families",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dieren_Families_FamilieID",
                table: "Dieren",
                column: "FamilieID",
                principalTable: "Families",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dieren_Families_FamilieID",
                table: "Dieren");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Families",
                table: "Families");

            migrationBuilder.RenameTable(
                name: "Families",
                newName: "Familie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Familie",
                table: "Familie",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dieren_Familie_FamilieID",
                table: "Dieren",
                column: "FamilieID",
                principalTable: "Familie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
