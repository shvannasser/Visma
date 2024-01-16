using VismasLoanCalculator.Models;

namespace VismasLoanCalculator.Interface
{
    public interface ILoan
    {
        decimal Amount { get; }
        int TermInYears { get; }
        decimal CalculateMonthlyPayment();
        IEnumerable<MonthlyPaymentModel> GenerateRepaymentSchedule();
    }
}
