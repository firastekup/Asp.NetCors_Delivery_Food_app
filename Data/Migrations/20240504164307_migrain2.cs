using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeleveryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class migrain2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodIdAliment",
                table: "Commande",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAliment",
                table: "Commande",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Commande_FoodIdAliment",
                table: "Commande",
                column: "FoodIdAliment");

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Food_FoodIdAliment",
                table: "Commande",
                column: "FoodIdAliment",
                principalTable: "Food",
                principalColumn: "IdAliment",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Food_FoodIdAliment",
                table: "Commande");

            migrationBuilder.DropIndex(
                name: "IX_Commande_FoodIdAliment",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "FoodIdAliment",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "IdAliment",
                table: "Commande");
        }
    }
}
