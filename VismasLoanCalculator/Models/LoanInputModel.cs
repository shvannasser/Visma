using System.ComponentModel.DataAnnotations;
using VismasLoanCalculator.Enums;

namespace VismasLoanCalculator.Models
{
    public class LoanInputModel
    {
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required]
        [Range(1, 30, ErrorMessage = "Term must be between 1 and 30 years")]
        public int TermInYears { get; set; }

        public LoanCategory LoanCategory { get; set; }

        public string LoanType { get; set; } = "Serial";
    }
}
