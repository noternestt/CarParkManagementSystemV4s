using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class VisitedLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisitedLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitedLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitedLocation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitedLocation_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eb4e058-74a3-4f85-92c4-8291c7572789", "AQAAAAIAAYagAAAAECRVdvhcm0FKDcg22TTRm8MdkRfMqXDJnqM/B022dridvJDNxEYqKngc8FqV+ylqBw==", "b3c01dc6-3ef2-4f85-9702-02090a00141d" });

            migrationBuilder.CreateIndex(
                name: "IX_VisitedLocation_LocationId",
                table: "VisitedLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitedLocation_UserId",
                table: "VisitedLocation",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitedLocation");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f0bf771-15b3-4394-b60d-f704552f05ca", "AQAAAAIAAYagAAAAEFllYesZnM5k3MDq1ZfZEVKGR7mO+x99t4nkpYUG+drB3SszOJin/pz4g13WRJRafA==", "6a92ab23-3fca-43eb-8bbd-feba44df32fc" });
        }
    }
}
