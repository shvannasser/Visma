using VismasLoanCalculator.Enums;
using VismasLoanCalculator.Interface;

namespace VismasLoanCalculator.Services
{
    public class InterestRateProvider : IInterestRateProvider
    {
        public decimal GetInterestRate(LoanCategory loanCategory)
        {

            return loanCategory switch
            {
                LoanCategory.Housing => 3.5m,
                LoanCategory.Car => 0,
                _ => throw new ArgumentException("Unsupported loan category", nameof(loanCategory)),
            };
        }
    }
}
