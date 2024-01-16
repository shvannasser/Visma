using VismasLoanCalculator.Interface;
using VismasLoanCalculator.Models;

namespace VismasLoanCalculator.Services
{
    public class SerialLoanCalculatorService : ILoanCalculator
    {

        decimal annualInterestRate = 3.5m;
        public IEnumerable<MonthlyPaymentModel> GenerateRepaymentSchedule(decimal amount, int termInYears)
        {
            var monthlyInterestRate = annualInterestRate / 12 / 100;
            var totalNumberOfPayments = termInYears * 12;
            var principalPayment = amount / totalNumberOfPayments;

            for (int month = 1; month <= totalNumberOfPayments; month++)
            {
                var interestPayment = amount * monthlyInterestRate;
                var totalPayment = principalPayment + interestPayment;
                amount -= principalPayment;

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
