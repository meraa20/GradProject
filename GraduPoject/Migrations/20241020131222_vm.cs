using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduPoject.Migrations
{
    /// <inheritdoc />
    public partial class vm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderDetails_OrderDetailsID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Deliveries_DeliveryID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Payment_PaymentID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Order_OrderDetailsID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderDetailsID",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Order",
                newName: "PaymentMethod");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentID",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryID",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Deliveries_DeliveryID",
                table: "OrderDetails",
                column: "DeliveryID",
                principalTable: "Deliveries",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Payment_PaymentID",
                table: "OrderDetails",
                column: "PaymentID",
                principalTable: "Payment",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Deliveries_DeliveryID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Payment_PaymentID",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "PaymentMethod",
                table: "Order",
                newName: "Status");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderDetailsID",
                table: "Order",
                column: "OrderDetailsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderDetails_OrderDetailsID",
                table: "Order",
                column: "OrderDetailsID",
                principalTable: "OrderDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Deliveries_DeliveryID",
                table: "OrderDetails",
                column: "DeliveryID",
                principalTable: "Deliveries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Payment_PaymentID",
                table: "OrderDetails",
                column: "PaymentID",
                principalTable: "Payment",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
