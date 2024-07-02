﻿// <auto-generated />
using System;
using AspNetBalanceSheet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetBalanceSheet.Migrations
{
    [DbContext(typeof(BalanceSheetContext))]
    [Migration("20240702065458_TestChangeData")]
    partial class TestChangeData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AspNetBalanceSheet.Models.Balance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("EntryType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Balances");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Account = "Cash",
                            Amount = 1000000.00m,
                            Category = "Liquid Assets",
                            EntryType = "AKTIVA"
                        },
                        new
                        {
                            ID = 2,
                            Account = "Saving",
                            Amount = 1000000.00m,
                            Category = "Equity",
                            EntryType = "PASIVA"
                        });
                });

            modelBuilder.Entity("AspNetBalanceSheet.Models.BalanceTransaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsFlip")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("BalanceTransactions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Account = "Cash",
                            Amount = 10000.00m,
                            Date = new DateTime(2024, 7, 2, 13, 54, 57, 66, DateTimeKind.Local).AddTicks(7083),
                            IsFlip = false,
                            TransactionType = "CREDIT"
                        },
                        new
                        {
                            ID = 2,
                            Account = "Expenses",
                            Amount = 10000.00m,
                            Date = new DateTime(2024, 7, 2, 13, 54, 57, 66, DateTimeKind.Local).AddTicks(7096),
                            IsFlip = false,
                            TransactionType = "DEBIT"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
