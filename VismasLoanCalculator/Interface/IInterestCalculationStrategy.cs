namespace VismasLoanCalculator.Interface
{
    public interface IInterestCalculationStrategy
    {
        decimal CalculateInterest(decimal principal, int termInYears);
    }
}
