using System.ComponentModel.DataAnnotations;

namespace AspNetBalanceSheet.Models
{
    public class BalanceTransaction
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Boolean IsFlip { get; set; }

        [Required]
        [MaxLength(20)]
        public string TransactionType { get; set; }

        [Required]
        [MaxLength(20)]
        public string Account { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}