using System;
using System.Runtime.CompilerServices;

namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public void payment(double P, double Y, double R)
        {
            double n = 12 * Y, r = R / (12 * 100);          
            double b = (1-Math.Pow((1 + r), -n));
            double amount = ((P * r) / b);
            Console.WriteLine("monthly payment " + amount);
        }
    }
}
