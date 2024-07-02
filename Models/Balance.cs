using System.ComponentModel.DataAnnotations;

namespace AspNetBalanceSheet.Models
{
    public class Balance
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string EntryType { get; set; }

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