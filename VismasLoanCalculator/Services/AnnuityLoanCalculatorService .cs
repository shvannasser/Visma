using VismasLoanCalculator.Interface;
using VismasLoanCalculator.Models;

namespace VismasLoanCalculator.Services
{
    public class AnnuityLoanCalculatorService : ILoanCalculator
    {
        private readonly IInterestRateProvider _interestRateProvider;

        public AnnuityLoanCalculatorService(IInterestRateProvider interestRateProvider)
        {
            _interestRateProvider = interestRateProvider;
        }

        public IEnumerable<MonthlyPaymentModel> GenerateRepaymentSchedule(LoanInputModel loanInput)
        {
            throw new NotImplementedException("Annuity loan calculation logic is not yet implemented.");
        }
    }
}


