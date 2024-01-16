﻿namespace VismasLoanCalculator.Models
{
    public class MonthlyPaymentModel
    {
        public int Month { get; set; }
        public decimal PrincipalPayment { get; set; }
        public decimal InterestPayment { get; set; }
        public decimal TotalPayment { get; set; }
    }
}
