using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class ParkingSessionSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1fd743c-3774-4212-8de3-f552e1d7aba4", "AQAAAAIAAYagAAAAENM5KXjVDbNpVJxVG28wMM7N5RGv6FNJq4aMGKLkOSyYXut3y3F+ThLvsBQQ3dw0aA==", "7f0f2f37-b269-4ea3-8aae-4ef687fdb30d" });

            migrationBuilder.InsertData(
                table: "ParkingSession",
                columns: new[] { "Id", "CreatedBy", "Date", "DateCreated", "DateUpdated", "EndTime", "LocationId", "StartTime", "Status", "UpdatedBy", "UserId", "VehicleId" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 2, 8, 16, 31, 3, 202, DateTimeKind.Local).AddTicks(7872), new DateTime(2025, 2, 8, 16, 31, 3, 202, DateTimeKind.Local).AddTicks(7872), new TimeSpan(0, 10, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), "Active", "system", 3, 16 },
                    { 2, "system", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 2, 8, 16, 31, 3, 202, DateTimeKind.Local).AddTicks(7876), new DateTime(2025, 2, 8, 16, 31, 3, 202, DateTimeKind.Local).AddTicks(7877), new TimeSpan(0, 12, 0, 0, 0), 1, new TimeSpan(0, 11, 0, 0, 0), "Active", "system", 3, 16 },
                    { 3, "system", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 2, 8, 16, 31, 3, 202, DateTimeKind.Local).AddTicks(7879), new DateTime(2025, 2, 8, 16, 31, 3, 202, DateTimeKind.Local).AddTicks(7880), new TimeSpan(0, 16, 0, 0, 0), 1, new TimeSpan(0, 15, 0, 0, 0), "Completed", "system", 3, 16 },
                    { 4, "system", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 2, 8, 16, 31, 3, 202, DateTimeKind.Local).AddTicks(7902), new DateTime(2025, 2, 8, 16, 31, 3, 202, DateTimeKind.Local).AddTicks(7902), new TimeSpan(0, 15, 0, 0, 0), 1, new TimeSpan(0, 14, 0, 0, 0), "Completed", "system", 3, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pricing_LocationId",
                table: "Pricing",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pricing_Location_LocationId",
                table: "Pricing",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pricing_Location_LocationId",
                table: "Pricing");

            migrationBuilder.DropIndex(
                name: "IX_Pricing_LocationId",
                table: "Pricing");

            migrationBuilder.DeleteData(
                table: "ParkingSession",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkingSession",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkingSession",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParkingSession",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b8ed863-3dd8-4c17-a065-85621f1e21ba", "AQAAAAIAAYagAAAAEGMY+A3oOw/0wA20K+s6VN9Vp8Y1SFpjS/n73zJKOxaGqoAiXEaIt0J2Kn/Wfk42dA==", "a70b951f-fac8-4c7b-a2e6-29a4cc7d93aa" });
        }
    }
}
