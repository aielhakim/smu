using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class MortgageEntity
    {
        public string borrowerName { get; set; }
        public double mortgageBalance { get; set; }
        public double annualInterestRate { get; set; }
        public double currentMonthlyPayment { get; set; }
        public double extraMonthlyPayment { get; set; }
        public double newMonthlyPayment { get { return calculateNewPayment(currentMonthlyPayment, extraMonthlyPayment); } }
        public int currentDurationInMonths { get { return calculateDurationInMonths(currentMonthlyPayment, annualInterestRate, mortgageBalance); } }
        public int newDurationInMonths { get { return calculateDurationInMonths(newMonthlyPayment, annualInterestRate, mortgageBalance); } }
        public double currentInterestAmount { get { return calculateInterestAmount(currentMonthlyPayment, currentDurationInMonths, mortgageBalance); } }
        public double newInterestAmount { get { return calculateInterestAmount(newMonthlyPayment, newDurationInMonths, mortgageBalance); } }
        public double newPaymentSavings { get { return currentInterestAmount - newInterestAmount;  } }
        public bool extraFees { get { return newDurationInMonths <= currentDurationInMonths / 2; } }

        public string extraFeesText { get { return extraFees ? " Extra Fees" : " No Fee"; } }
        public string mortgageBalanceText { get { return string.Format(" ${0:0.00}", Math.Round(mortgageBalance, 2)); } }
        public string annualInterestRateText { get { return string.Format(" {0:0.000}%", Math.Round(annualInterestRate, 3)); } }
        public string currentMonthlyPaymentText { get { return string.Format(" ${0:0.00}", Math.Round(currentMonthlyPayment, 2)); } }
        public string currentInterestAmountText { get { return string.Format(" ${0:0.00}", Math.Round(currentInterestAmount, 2)); } }
        public string newMonthlyPaymentText { get { return string.Format(" ${0:0.00}", Math.Round(newMonthlyPayment, 2)); } }
        public string newInterestAmountText { get { return string.Format(" ${0:0.00}", Math.Round(newInterestAmount, 2)); } }
        public string newPaymentSavingsText { get { return string.Format(" ${0:0.00}", Math.Round(newPaymentSavings, 2)); } }

        public string currentDurationInYearsMonths
        {
            get { return calculateDurationInYearsMonths(currentDurationInMonths); }
        }
        public string newDurationInYearsMonths
        {
            get { return calculateDurationInYearsMonths(newDurationInMonths); }
        }

        private static string calculateDurationInYearsMonths(int durationInMonths)
        {
            int durationYears = durationInMonths / 12;
            int durationYearMonthRestOnly = durationInMonths % 12;

            return string.Format("{0}yrs {1}mo", durationYears, durationYearMonthRestOnly);
        }

        private static double calculateNewPayment(double currentMonthlyPayment, double extraMonthlyPayment)
        {
            return currentMonthlyPayment + extraMonthlyPayment;
        }

        private static int calculateDurationInMonths(double monthlyPayment, double interestRate, double mortagageBalance)
        {
            double i = interestRate / 100 / 12;

            return (int)Math.Round(
                Math.Log((monthlyPayment / i) / ((monthlyPayment / i) - mortagageBalance))
                / Math.Log(1 + i));
        }

        private static double calculateInterestAmount(double monthlyPayment, double durationInMonths, double mortagageBalance)
        {
            return (monthlyPayment * durationInMonths) - mortagageBalance;
        }
    }
}
