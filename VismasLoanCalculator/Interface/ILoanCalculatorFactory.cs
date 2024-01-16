using VismasLoanCalculator.Services;

namespace VismasLoanCalculator.Interface
{
    public interface ILoanCalculatorFactory
    {
        ILoanCalculator Create(string loanType);
    }

    public class LoanCalculatorFactory : ILoanCalculatorFactory
    {
        public ILoanCalculator Create(string loanType)
        {
            return loanType switch
            {
                "Serial" => new SerialLoanCalculatorService(),
                "Annuity" => new AnnuityLoanCalculator(),
                _ => throw new ArgumentException("Invalid loan type", nameof(loanType)),
            };
        }
    }
}
