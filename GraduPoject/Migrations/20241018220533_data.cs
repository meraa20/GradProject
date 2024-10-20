using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduPoject.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_AspNetUsers_useid",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessOwners_AspNetUsers_useid",
                table: "BusinessOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartID",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_BusinessOwners_BOID",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserID",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Payments_PaymentID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailsID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_OrderDetails_OrderDetailsID",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_UserID",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_BusinessOwners_BOID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Rates_RateID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Products_ProductID",
                table: "Rates");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_BusinessOwners_BusinessOwnerID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_AspNetUsers_useid",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Sign_upVm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rates",
                table: "Rates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BusinessOwners",
                table: "BusinessOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Rates",
                newName: "Rate");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "BusinessOwners",
                newName: "BusinessOwner");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "Admin");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "NameArtist");

            migrationBuilder.RenameIndex(
                name: "IX_Users_useid",
                table: "User",
                newName: "IX_User_useid");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserID",
                table: "Review",
                newName: "IX_Review_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ProductID",
                table: "Review",
                newName: "IX_Review_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_BusinessOwnerID",
                table: "Review",
                newName: "IX_Review_BusinessOwnerID");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_ProductID",
                table: "Rate",
                newName: "IX_Rate_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_UserID",
                table: "Payment",
                newName: "IX_Payment_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_OrderDetailsID",
                table: "Payment",
                newName: "IX_Payment_OrderDetailsID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserID",
                table: "Order",
                newName: "IX_Order_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_OrderDetailsID",
                table: "Order",
                newName: "IX_Order_OrderDetailsID");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessOwners_useid",
                table: "BusinessOwner",
                newName: "IX_BusinessOwner_useid");

            migrationBuilder.RenameIndex(
                name: "IX_Admins_useid",
                table: "Admin",
                newName: "IX_Admin_useid");

            migrationBuilder.AddColumn<string>(
                name: "NameAntiqae",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CartID",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rate",
                table: "Rate",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BusinessOwner",
                table: "BusinessOwner",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_AspNetUsers_useid",
                table: "Admin",
                column: "useid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessOwner_AspNetUsers_useid",
                table: "BusinessOwner",
                column: "useid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartID",
                table: "CartItems",
                column: "CartID",
                principalTable: "Carts",
                principalColumn: "CartID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_User_UserID",
                table: "Carts",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_BusinessOwner_BOID",
                table: "Notifications",
                column: "BOID",
                principalTable: "BusinessOwner",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_User_UserID",
                table: "Notifications",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderDetails_OrderDetailsID",
                table: "Order",
                column: "OrderDetailsID",
                principalTable: "OrderDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_UserID",
                table: "Order",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Order_OrderID",
                table: "OrderDetails",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Payment_PaymentID",
                table: "OrderDetails",
                column: "PaymentID",
                principalTable: "Payment",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_OrderDetails_OrderDetailsID",
                table: "Payment",
                column: "OrderDetailsID",
                principalTable: "OrderDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_UserID",
                table: "Payment",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BusinessOwner_BOID",
                table: "Products",
                column: "BOID",
                principalTable: "BusinessOwner",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Rate_RateID",
                table: "Products",
                column: "RateID",
                principalTable: "Rate",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_Products_ProductID",
                table: "Rate",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_BusinessOwner_BusinessOwnerID",
                table: "Review",
                column: "BusinessOwnerID",
                principalTable: "BusinessOwner",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Products_ProductID",
                table: "Review",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_UserID",
                table: "Review",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_User_AspNetUsers_useid",
                table: "User",
                column: "useid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_AspNetUsers_useid",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessOwner_AspNetUsers_useid",
                table: "BusinessOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartID",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_User_UserID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_BusinessOwner_BOID",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_User_UserID",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderDetails_OrderDetailsID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_UserID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Order_OrderID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Payment_PaymentID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_OrderDetails_OrderDetailsID",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_UserID",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_BusinessOwner_BOID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Rate_RateID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Rate_Products_ProductID",
                table: "Rate");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_BusinessOwner_BusinessOwnerID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Products_ProductID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_UserID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_User_AspNetUsers_useid",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rate",
                table: "Rate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BusinessOwner",
                table: "BusinessOwner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "NameAntiqae",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "Rate",
                newName: "Rates");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "BusinessOwner",
                newName: "BusinessOwners");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "Admins");

            migrationBuilder.RenameColumn(
                name: "NameArtist",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_User_useid",
                table: "Users",
                newName: "IX_Users_useid");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserID",
                table: "Reviews",
                newName: "IX_Reviews_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Review_ProductID",
                table: "Reviews",
                newName: "IX_Reviews_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Review_BusinessOwnerID",
                table: "Reviews",
                newName: "IX_Reviews_BusinessOwnerID");

            migrationBuilder.RenameIndex(
                name: "IX_Rate_ProductID",
                table: "Rates",
                newName: "IX_Rates_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_UserID",
                table: "Payments",
                newName: "IX_Payments_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_OrderDetailsID",
                table: "Payments",
                newName: "IX_Payments_OrderDetailsID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserID",
                table: "Orders",
                newName: "IX_Orders_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_OrderDetailsID",
                table: "Orders",
                newName: "IX_Orders_OrderDetailsID");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessOwner_useid",
                table: "BusinessOwners",
                newName: "IX_BusinessOwners_useid");

            migrationBuilder.RenameIndex(
                name: "IX_Admin_useid",
                table: "Admins",
                newName: "IX_Admins_useid");

            migrationBuilder.AlterColumn<int>(
                name: "CartID",
                table: "CartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rates",
                table: "Rates",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BusinessOwners",
                table: "BusinessOwners",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BOID = table.Column<int>(type: "int", nullable: true),
                    ReviewID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reports_BusinessOwners_BOID",
                        column: x => x.BOID,
                        principalTable: "BusinessOwners",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Reports_Reviews_ReviewID",
                        column: x => x.ReviewID,
                        principalTable: "Reviews",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Sign_upVm",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Confirmpassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sign_upVm", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_BOID",
                table: "Reports",
                column: "BOID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReviewID",
                table: "Reports",
                column: "ReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UserID",
                table: "Reports",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_AspNetUsers_useid",
                table: "Admins",
                column: "useid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessOwners_AspNetUsers_useid",
                table: "BusinessOwners",
                column: "useid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartID",
                table: "CartItems",
                column: "CartID",
                principalTable: "Carts",
                principalColumn: "CartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserID",
                table: "Carts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_BusinessOwners_BOID",
                table: "Notifications",
                column: "BOID",
                principalTable: "BusinessOwners",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserID",
                table: "Notifications",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderID",
                table: "OrderDetails",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Payments_PaymentID",
                table: "OrderDetails",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailsID",
                table: "Orders",
                column: "OrderDetailsID",
                principalTable: "OrderDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_OrderDetails_OrderDetailsID",
                table: "Payments",
                column: "OrderDetailsID",
                principalTable: "OrderDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_UserID",
                table: "Payments",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BusinessOwners_BOID",
                table: "Products",
                column: "BOID",
                principalTable: "BusinessOwners",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Rates_RateID",
                table: "Products",
                column: "RateID",
                principalTable: "Rates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Products_ProductID",
                table: "Rates",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_BusinessOwners_BusinessOwnerID",
                table: "Reviews",
                column: "BusinessOwnerID",
                principalTable: "BusinessOwners",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductID",
                table: "Reviews",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserID",
                table: "Reviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AspNetUsers_useid",
                table: "Users",
                column: "useid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
