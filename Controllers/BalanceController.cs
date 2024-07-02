using AspNetBalanceSheet.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspNetBalanceSheet.Controllers
{
    public class BalanceController : Controller
    {
        private readonly BalanceSheetContext _context;

        public BalanceController(BalanceSheetContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var balances = _context.Balances.ToList();
            var transactions = _context.BalanceTransactions.ToList();

            return View((balances, transactions));
        }
    }
}