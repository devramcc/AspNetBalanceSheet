using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetBalanceSheet.Models
{
    public class BalanceTransaction
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("BalanceRecord")]
        public int BalanceRecordId { get; set; }
        public BalanceRecord BalanceRecord { get; set; }

        [Required]
        [MaxLength(20)]
        public string TransactionType { get; set; }

        [Required]
        [MaxLength(20)]
        public string Category { get; set; }

        [Required]
        [MaxLength(20)]
        public string Account { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}