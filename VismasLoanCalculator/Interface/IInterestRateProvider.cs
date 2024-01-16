using VismasLoanCalculator.Enums;

namespace VismasLoanCalculator.Interface
{
    public interface IInterestRateProvider
    {
        decimal GetInterestRate(LoanCategory loanCategory);
    }
}
