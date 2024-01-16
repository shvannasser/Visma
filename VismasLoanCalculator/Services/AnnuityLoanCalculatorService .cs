using VismasLoanCalculator.Interface;
using VismasLoanCalculator.Models;

namespace VismasLoanCalculator.Services
{
    public class AnnuityLoanCalculator : ILoanCalculator
    {
        public IEnumerable<MonthlyPaymentModel> GenerateRepaymentSchedule(decimal amount, int termInYears)
        {
            throw new NotImplementedException("Annuity loan calculation logic is not yet implemented.");
        }
    }

}