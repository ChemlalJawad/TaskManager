using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToDBContextInINterface : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 13, 50, 24, 542, DateTimeKind.Local).AddTicks(4241), new DateTime(2023, 10, 25, 13, 50, 24, 542, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 50, 24, 542, DateTimeKind.Local).AddTicks(4233), new DateTime(2023, 10, 25, 13, 50, 24, 542, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -2,
                column: "DueDate",
                value: new DateTime(2023, 11, 25, 13, 50, 24, 542, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -1,
                column: "DueDate",
                value: new DateTime(2023, 11, 25, 13, 50, 24, 542, DateTimeKind.Local).AddTicks(4259));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 13, 11, 51, 952, DateTimeKind.Local).AddTicks(3516), new DateTime(2023, 10, 25, 13, 11, 51, 952, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 11, 51, 952, DateTimeKind.Local).AddTicks(3507), new DateTime(2023, 10, 25, 13, 11, 51, 952, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -2,
                column: "DueDate",
                value: new DateTime(2023, 11, 25, 13, 11, 51, 952, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -1,
                column: "DueDate",
                value: new DateTime(2023, 11, 25, 13, 11, 51, 952, DateTimeKind.Local).AddTicks(3534));
        }
    }
}
