using VismasLoanCalculator.Enums;

namespace VismasLoanCalculator.Interface
{
    public interface ILoanCalculatorFactory
    {
        ILoanCalculator Create(LoanCategory loanCategory, string loanType);
    }

}

