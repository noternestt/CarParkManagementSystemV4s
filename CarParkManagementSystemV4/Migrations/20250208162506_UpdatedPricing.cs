using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarParkManagementSystemV4.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPricing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

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

            migrationBuilder.DropColumn(
                name: "OverstayPenalty",
                table: "Pricing");

            migrationBuilder.AddColumn<int>(
                name: "ParkingSessionId",
                table: "PaymentMethod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42c7e6e6-1782-4640-9ae3-0d61d8288f02", "AQAAAAIAAYagAAAAED4pd81wLlPdPSOhJg6cGIBnRGAPWfSz9zP/LsfQL2EpZ/4REYZOo2G1MrC82hO7HQ==", "b0f417de-9d2f-42e1-9bb8-ea6a58755d64" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParkingSessionId",
                table: "PaymentMethod");

            migrationBuilder.AddColumn<double>(
                name: "OverstayPenalty",
                table: "Pricing",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParkingSessionId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

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
        }
    }
}
