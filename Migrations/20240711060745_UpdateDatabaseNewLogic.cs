using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetBalanceSheet.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseNewLogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BalanceTransactions",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Balances",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Balances",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Date",
                table: "BalanceTransactions");

            migrationBuilder.DropColumn(
                name: "IsFlip",
                table: "BalanceTransactions");

            migrationBuilder.AddColumn<int>(
                name: "BalanceRecordId",
                table: "BalanceTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "BalanceTransactions",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BalanceRecords",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsFlip = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FlipAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TransferFrom = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TransferTo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceRecords", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BalanceTransactions_BalanceRecordId",
                table: "BalanceTransactions",
                column: "BalanceRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_BalanceTransactions_BalanceRecords_BalanceRecordId",
                table: "BalanceTransactions",
                column: "BalanceRecordId",
                principalTable: "BalanceRecords",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BalanceTransactions_BalanceRecords_BalanceRecordId",
                table: "BalanceTransactions");

            migrationBuilder.DropTable(
                name: "BalanceRecords");

            migrationBuilder.DropIndex(
                name: "IX_BalanceTransactions_BalanceRecordId",
                table: "BalanceTransactions");

            migrationBuilder.DropColumn(
                name: "BalanceRecordId",
                table: "BalanceTransactions");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "BalanceTransactions");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "BalanceTransactions",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsFlip",
                table: "BalanceTransactions",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "BalanceTransactions",
                columns: new[] { "ID", "Account", "Amount", "Date", "IsFlip", "TransactionType" },
                values: new object[,]
                {
                    { 1, "Cash", 10000.00m, new DateTime(2024, 7, 2, 13, 54, 57, 66, DateTimeKind.Local).AddTicks(7083), false, "CREDIT" },
                    { 2, "Expenses", 10000.00m, new DateTime(2024, 7, 2, 13, 54, 57, 66, DateTimeKind.Local).AddTicks(7096), false, "DEBIT" }
                });

            migrationBuilder.InsertData(
                table: "Balances",
                columns: new[] { "ID", "Account", "Amount", "Category", "EntryType" },
                values: new object[,]
                {
                    { 1, "Cash", 1000000.00m, "Liquid Assets", "AKTIVA" },
                    { 2, "Saving", 1000000.00m, "Equity", "PASIVA" }
                });
        }
    }
}
