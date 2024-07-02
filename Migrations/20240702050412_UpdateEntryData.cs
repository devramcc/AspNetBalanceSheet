using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetBalanceSheet.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Amount", "Date", "TransactionType" },
                values: new object[] { 10000.00m, new DateTime(2024, 7, 2, 12, 4, 11, 738, DateTimeKind.Local).AddTicks(1281), "CREDIT" });

            migrationBuilder.UpdateData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Account", "Amount", "Date", "TransactionType" },
                values: new object[] { "Expenses", 10000.00m, new DateTime(2024, 7, 2, 12, 4, 11, 738, DateTimeKind.Local).AddTicks(1307), "DEBIT" });

            migrationBuilder.UpdateData(
                table: "Balances",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Amount", "Category", "EntryType" },
                values: new object[] { 1000000.00m, "Liquid Assets", "AKTIVA" });

            migrationBuilder.UpdateData(
                table: "Balances",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Account", "Amount", "Category", "EntryType" },
                values: new object[] { "Saving", 1000000.00m, "Equity", "PASIVA" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Amount", "Date", "TransactionType" },
                values: new object[] { 50.00m, new DateTime(2024, 7, 2, 11, 23, 2, 593, DateTimeKind.Local).AddTicks(4384), "Expense" });

            migrationBuilder.UpdateData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Account", "Amount", "Date", "TransactionType" },
                values: new object[] { "Bank", 2000.00m, new DateTime(2024, 7, 2, 11, 23, 2, 593, DateTimeKind.Local).AddTicks(4397), "Income" });

            migrationBuilder.UpdateData(
                table: "Balances",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Amount", "Category", "EntryType" },
                values: new object[] { 50.00m, "Food", "Expense" });

            migrationBuilder.UpdateData(
                table: "Balances",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Account", "Amount", "Category", "EntryType" },
                values: new object[] { "Bank", 2000.00m, "Salary", "Income" });
        }
    }
}
