using Microsoft.EntityFrameworkCore;
using AspNetBalanceSheet.Models;
using System.Transactions;

namespace AspNetBalanceSheet.Data
{
    public class BalanceSheetContext : DbContext
    {
        public BalanceSheetContext(DbContextOptions<BalanceSheetContext> options) : base(options)
        {
        }

        public DbSet<Balance> Balances { get; set; }
        public DbSet<BalanceRecord> BalanceRecords { get; set; }
        public DbSet<BalanceTransaction> BalanceTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BalanceTransaction>()
                .HasOne(t => t.BalanceRecord)
                .WithMany()
                .HasForeignKey(t => t.BalanceRecordId)
                .OnDelete(DeleteBehavior.Cascade);

            // modelBuilder.Entity<Balance>().HasData(
            //     new Balance { ID = 1, EntryType = "AKTIVA", Category = "Liquid Assets", Account = "Cash", Amount = 1000000.00m },
            //     new Balance { ID = 2, EntryType = "PASIVA", Category = "Equity", Account = "Saving", Amount = 1000000.00m }
            // );

            // modelBuilder.Entity<BalanceRecord>().HasData(
            //     new BalanceRecord { ID = 1, Date = DateTime.Now, IsFlip = false, TransactionType = "CREDIT", Account = "Cash", Amount = 10000.00m },
            //     new BalanceRecord { ID = 2, Date = DateTime.Now, IsFlip = false, TransactionType = "DEBIT", Account = "Expenses", Amount = 10000.00m }
            // );

            base.OnModelCreating(modelBuilder);
        }
    }
}
