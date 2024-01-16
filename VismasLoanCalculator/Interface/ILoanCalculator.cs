using VismasLoanCalculator.Models;

namespace VismasLoanCalculator.Interface
{
    public interface ILoanCalculator
    {
        IEnumerable<MonthlyPaymentModel> GenerateRepaymentSchedule(decimal amount, int termInYears);
    }

}
