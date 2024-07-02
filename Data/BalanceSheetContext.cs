using Microsoft.EntityFrameworkCore;
using AspNetBalanceSheet.Models;

namespace AspNetBalanceSheet.Data
{
    public class BalanceSheetContext : DbContext
    {
        public BalanceSheetContext(DbContextOptions<BalanceSheetContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
