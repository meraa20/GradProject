using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduPoject.Migrations
{
    /// <inheritdoc />
    public partial class da : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rate_Products_ProductID",
                table: "Rate");

            migrationBuilder.DropIndex(
                name: "IX_Rate_ProductID",
                table: "Rate");

            migrationBuilder.DropIndex(
                name: "IX_Products_RateID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Rate");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RateID",
                table: "Products",
                column: "RateID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_RateID",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Rate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rate_ProductID",
                table: "Rate",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RateID",
                table: "Products",
                column: "RateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_Products_ProductID",
                table: "Rate",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
