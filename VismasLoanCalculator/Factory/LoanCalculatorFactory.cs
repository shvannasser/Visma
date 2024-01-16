using VismasLoanCalculator.Enums;
using VismasLoanCalculator.Interface;
using VismasLoanCalculator.Services;

namespace VismasLoanCalculator.Factory
{
    public class LoanCalculatorFactory : ILoanCalculatorFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public LoanCalculatorFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ILoanCalculator Create(LoanCategory loanCategory, string loanType)
        {
            if (loanType == "Serial")
            {
                return _serviceProvider.GetService(typeof(SerialLoanCalculatorService)) as SerialLoanCalculatorService;
            }
            else if (loanType == "Annuity")
            {
                return _serviceProvider.GetService(typeof(AnnuityLoanCalculatorService)) as AnnuityLoanCalculatorService;
            }
            else
            {
                throw new ArgumentException("Invalid loan type");
            }
        }
    }
}
