using System;
using System.Collections.Generic;

namespace Q2
{
    class Program
    {
       static List<MortgageEntity> mortgageEntities;

        static void Main(string[] args)
        {
            mortgageEntities = new List<MortgageEntity>();
            int n = readN();

            for (int i = 0; i < n; i++)
            {
                int borrowerNumber = i + 1;
                mortgageEntities.Add(new MortgageEntity
                {
                    borrowerName = readBorrowerName(borrowerNumber),
                    mortgageBalance = readMortgageBalance(borrowerNumber),
                    annualInterestRate = readAnnualInterestRate(borrowerNumber),
                    currentMonthlyPayment = readCurrentMonthlyPayment(borrowerNumber),
                    extraMonthlyPayment = readExtraMonthlyPayment(borrowerNumber)
                });
                Console.WriteLine("");
                Console.WriteLine("");
            }
            writeResults();
            Console.Read();
        }

        private static int readN()
        {
            Console.Write("Enter the number of entries to calculate mortgage: ");

            string nText = Console.ReadLine();
            int n;

            if (int.TryParse(nText, out n))
            {
                return n;
            }
            else
            {
                return readN();
            }
        }

        private static string readBorrowerName(int number)
        {
            Console.Write(number + "- Enter the name of the borrower: ");

            return Console.ReadLine();
        }

        private static double readMortgageBalance(int number)
        {
            Console.Write(number + "- Enter the mortgage balance: $");

            string mbText = Console.ReadLine();
            double mb;

            if (double.TryParse(mbText, out mb))
            {
                return mb;
            }
            else
            {
                return readMortgageBalance(number);
            }
        }

        private static double readAnnualInterestRate(int number)
        {
            Console.Write(number + "- Enter the annual interest rate: ");

            string aiText = Console.ReadLine();
            double ai;

            if (double.TryParse(aiText, out ai))
            {
                return ai;
            }
            else
            {
                return readAnnualInterestRate(number);
            }
        }

        private static double readCurrentMonthlyPayment(int number)
        {
            Console.Write(number + "- Enter the current monthly payment: $");

            string mpText = Console.ReadLine();
            double mp;

            if (double.TryParse(mpText, out mp))
            {
                return mp;
            }
            else
            {
                return readCurrentMonthlyPayment(number);
            }
        }

        private static double readExtraMonthlyPayment(int number)
        {
            Console.Write(number + "- Enter the extra monthly payment: $");

            string empText = Console.ReadLine();
            double emp;

            if (double.TryParse(empText, out emp))
            {
                return emp;
            }
            else
            {
                return readExtraMonthlyPayment(number);
            }
        }

        public static void writeResults()
        {
            string rowStrurcture = "{0,-20} {1,-20} {2,-20} {3,-10} {4,-10} {5,-15} {6,-10} {7,-10} {8,-15} {9,-10} {10,-10}";

            Console.WriteLine(string.Format(rowStrurcture,
                "Name", "|Mortgage Balance", "|Interest Rate", "|", "Current",
                "", "|", "New", "", " |Savings", " |Fees"));

            Console.WriteLine(string.Format(rowStrurcture,
                "", "", "", " Payment", " Duration",
                " Interset", "| Payment", "Duration", " Interest", "", ""));

            mortgageEntities.Sort();

            foreach (var item in mortgageEntities)
            {
                Console.WriteLine(string.Format(rowStrurcture,
               item.borrowerName, item.mortgageBalanceText, item.annualInterestRateText,
               item.currentMonthlyPaymentText, item.currentDurationInYearsMonths, item.currentInterestAmountText,
               item.newMonthlyPaymentText, item.newDurationInYearsMonths, item.newInterestAmountText,
               item.newPaymentSavingsText, item.extraFeesText));
            }
        }
    }
}
