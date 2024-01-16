using VismasLoanCalculator.Interface;
using VismasLoanCalculator.Models;

namespace VismasLoanCalculator.Data
{
    public abstract class Loan : ILoan
    {
        public decimal Amount { get; protected set; }
        public int TermInYears { get; protected set; }

        protected Loan(decimal amount, int termInYears)
        {
            Amount = amount;
            TermInYears = termInYears;
        }

        public abstract decimal CalculateMonthlyPayment();
        public abstract IEnumerable<MonthlyPaymentModel> GenerateRepaymentSchedule();
    }

}
