using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetBalanceSheet.Migrations
{
    /// <inheritdoc />
    public partial class TestChangeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 2, 13, 54, 57, 66, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 2, 13, 54, 57, 66, DateTimeKind.Local).AddTicks(7096));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 2, 12, 4, 11, 738, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 2, 12, 4, 11, 738, DateTimeKind.Local).AddTicks(1307));
        }
    }
}
