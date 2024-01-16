using System;
using System.Collections.Generic;
using VismasLoanCalculator.Interface;
using VismasLoanCalculator.Models;

namespace VismasLoanCalculator.Data
{

    public class HousingLoan : ILoan
    {
        public decimal Amount { get; private set; }
        public int TermInYears { get; private set; }

        private readonly IInterestCalculationStrategy _interestCalculationStrategy;

        public HousingLoan(decimal amount, int termInYears, IInterestCalculationStrategy interestCalculationStrategy)
        {
            Amount = amount;
            TermInYears = termInYears;
            _interestCalculationStrategy = interestCalculationStrategy;
        }

        public decimal CalculateMonthlyPayment()
        {
            var interest = _interestCalculationStrategy.CalculateInterest(Amount, TermInYears);
            var totalRepayment = Amount + interest;
            return totalRepayment / (TermInYears * 12);
        }

        public IEnumerable<MonthlyPaymentModel> GenerateRepaymentSchedule()
        {
            var monthlyPayment = CalculateMonthlyPayment();
            for (int month = 1; month <= TermInYears * 12; month++)
            {
                yield return new MonthlyPaymentModel
                {
                    Month = month,
                    PrincipalPayment = Amount / (TermInYears * 12),
                    InterestPayment = monthlyPayment - (Amount / (TermInYears * 12)),
                    TotalPayment = monthlyPayment
                };
            }
        }
    }



}
