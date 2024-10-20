using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduPoject.Migrations
{
    /// <inheritdoc />
    public partial class dat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    BOID = table.Column<int>(type: "int", nullable: true),
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Report_BusinessOwner_BOID",
                        column: x => x.BOID,
                        principalTable: "BusinessOwner",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Report_Review_ReviewID",
                        column: x => x.ReviewID,
                        principalTable: "Review",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Report_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Report_BOID",
                table: "Report",
                column: "BOID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_ReviewID",
                table: "Report",
                column: "ReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_UserID",
                table: "Report",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Report");
        }
    }
}
