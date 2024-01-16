using System.ComponentModel.DataAnnotations;

namespace VismasLoanCalculator.Models
{
    public class LoanInputModel
    {


        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Term must be between 1 and 100 years")]
        public int TermInYears { get; set; }

        public string LoanType { get; set; } = "Serial";


    }
}
