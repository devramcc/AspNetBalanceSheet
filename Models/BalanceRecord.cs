using System.ComponentModel.DataAnnotations;

namespace AspNetBalanceSheet.Models
{
    public class BalanceRecord
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Boolean IsFlip { get; set; }

        [Required]
        public decimal FlipAmount { get; set; }

        [Required]
        [MaxLength(20)]
        public string TransferFrom { get; set; }

        [Required]
        [MaxLength(20)]
        public string TransferTo { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}