using VismasLoanCalculator.Interface;
using VismasLoanCalculator.Models;

namespace VismasLoanCalculator.Services
{
    public class SerialLoanCalculatorService : ILoanCalculator
    {
        private readonly IInterestRateProvider _interestRateProvider;

        public SerialLoanCalculatorService(IInterestRateProvider interestRateProvider)
        {
            _interestRateProvider = interestRateProvider;
        }

        public IEnumerable<MonthlyPaymentModel> GenerateRepaymentSchedule(LoanInputModel loanInput)
        {
            decimal annualInterestRate = _interestRateProvider.GetInterestRate(loanInput.LoanCategory);
            var monthlyInterestRate = annualInterestRate / 12 / 100;
            var totalNumberOfPayments = loanInput.TermInYears * 12;
            var principalPayment = loanInput.Amount / totalNumberOfPayments;
            decimal remainingAmount = loanInput.Amount;

            for (int month = 1; month <= totalNumberOfPayments; month++)
            {
                var interestPayment = remainingAmount * monthlyInterestRate;
                var totalPayment = principalPayment + interestPayment;
                remainingAmount -= principalPayment;

                yield return new MonthlyPaymentModel
                {
                    Month = month,
                    PrincipalPayment = principalPayment,
                    InterestPayment = interestPayment,
                    TotalPayment = totalPayment
                };
            }
        }
    }
}

