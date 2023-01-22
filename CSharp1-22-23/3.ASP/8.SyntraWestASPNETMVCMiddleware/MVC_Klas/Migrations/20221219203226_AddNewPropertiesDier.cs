using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCKlas.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPropertiesDier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dieren_Families_FamilieID",
                table: "Dieren");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dieren",
                table: "Dieren");

            migrationBuilder.RenameTable(
                name: "Dieren",
                newName: "DierenLijst");

            migrationBuilder.RenameColumn(
                name: "Gevaarlijk",
                table: "DierenLijst",
                newName: "GevaarlijkNaam");

            migrationBuilder.RenameIndex(
                name: "IX_Dieren_FamilieID",
                table: "DierenLijst",
                newName: "IX_DierenLijst_FamilieID");

            migrationBuilder.AddColumn<string>(
                name: "GeslachtNaam",
                table: "DierenLijst",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kleur",
                table: "DierenLijst",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DierenLijst",
                table: "DierenLijst",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DierenLijst_Families_FamilieID",
                table: "DierenLijst",
                column: "FamilieID",
                principalTable: "Families",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DierenLijst_Families_FamilieID",
                table: "DierenLijst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DierenLijst",
                table: "DierenLijst");

            migrationBuilder.DropColumn(
                name: "GeslachtNaam",
                table: "DierenLijst");

            migrationBuilder.DropColumn(
                name: "Kleur",
                table: "DierenLijst");

            migrationBuilder.RenameTable(
                name: "DierenLijst",
                newName: "Dieren");

            migrationBuilder.RenameColumn(
                name: "GevaarlijkNaam",
                table: "Dieren",
                newName: "Gevaarlijk");

            migrationBuilder.RenameIndex(
                name: "IX_DierenLijst_FamilieID",
                table: "Dieren",
                newName: "IX_Dieren_FamilieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dieren",
                table: "Dieren",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dieren_Families_FamilieID",
                table: "Dieren",
                column: "FamilieID",
                principalTable: "Families",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
