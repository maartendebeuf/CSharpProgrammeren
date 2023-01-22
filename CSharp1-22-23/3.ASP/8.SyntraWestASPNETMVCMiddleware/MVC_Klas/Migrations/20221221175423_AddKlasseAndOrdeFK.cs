using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCKlas.Migrations
{
    /// <inheritdoc />
    public partial class AddKlasseAndOrdeFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Klasse",
                table: "Families");

            migrationBuilder.DropColumn(
                name: "Orde",
                table: "Families");

            migrationBuilder.AddColumn<int>(
                name: "KlasseID",
                table: "Families",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "OrdeID",
                table: "Families",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Families_KlasseID",
                table: "Families",
                column: "KlasseID");

            migrationBuilder.CreateIndex(
                name: "IX_Families_OrdeID",
                table: "Families",
                column: "OrdeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Families_Klasses_KlasseID",
                table: "Families",
                column: "KlasseID",
                principalTable: "Klasses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Families_Ordes_OrdeID",
                table: "Families",
                column: "OrdeID",
                principalTable: "Ordes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Families_Klasses_KlasseID",
                table: "Families");

            migrationBuilder.DropForeignKey(
                name: "FK_Families_Ordes_OrdeID",
                table: "Families");

            migrationBuilder.DropIndex(
                name: "IX_Families_KlasseID",
                table: "Families");

            migrationBuilder.DropIndex(
                name: "IX_Families_OrdeID",
                table: "Families");

            migrationBuilder.DropColumn(
                name: "KlasseID",
                table: "Families");

            migrationBuilder.DropColumn(
                name: "OrdeID",
                table: "Families");

            migrationBuilder.AddColumn<string>(
                name: "Klasse",
                table: "Families",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Orde",
                table: "Families",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
