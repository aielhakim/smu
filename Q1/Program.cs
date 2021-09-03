using System;
using System.Globalization;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = readA();

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(Calculate(a, i));
            }

            Console.Read();
        }

        private static int readA()
        {
            Console.Write("Enter the value for a: ");

            string aText = Console.ReadLine();
            int a;

            if (int.TryParse(aText, out a))
            {
                return a;
            }
            else
            {
                return readA();
            }
        }

        private static decimal Calculate(int a, int x)
        {
            var eqPart1 = decimal.Parse(Math.Pow(a, (2 * x)).ToString(), NumberStyles.Float);
            var eqPart2 = decimal.Parse(Math.Pow(a, x).ToString(), NumberStyles.Float);
            var eqPart3 = decimal.Parse("1", NumberStyles.Float);

            return Math.Round(eqPart1 - eqPart2  + eqPart3);
        }

    }
}
