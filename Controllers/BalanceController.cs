using AspNetBalanceSheet.Data;
using AspNetBalanceSheet.Models;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateTransaction(DateTime date, bool isFlip, string transferFrom, string transferTo, decimal amount)
        {
            if (ModelState.IsValid)
            {
                var creditTransaction = new BalanceTransaction
                {
                    Date = date,
                    IsFlip = isFlip,
                    Account = transferFrom,
                    TransactionType = "CREDIT",
                    Amount = amount * -1
                };

                var debitTransaction = new BalanceTransaction
                {
                    Date = date,
                    IsFlip = isFlip,
                    TransactionType = "DEBIT",
                    Account = transferTo,
                    Amount = amount
                };

                var balanceFrom = _context.Balances.FirstOrDefault(b => b.Account == transferFrom);
                if (balanceFrom != null)
                {
                    balanceFrom.Amount += creditTransaction.Amount;
                }

                // Update Balance for transferTo
                var balanceTo = _context.Balances.FirstOrDefault(b => b.Account == transferTo);
                if (balanceTo != null)
                {
                    balanceTo.Amount += debitTransaction.Amount;
                }

                _context.BalanceTransactions.Add(creditTransaction);
                _context.BalanceTransactions.Add(debitTransaction);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}