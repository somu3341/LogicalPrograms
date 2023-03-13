using System;
namespace LogicalPrograms
{
    public class SquareRoot
    {
        public void newton(double c)
        {
            double t = c;
            double epsilon = 1e-15;
            if (c > 0)
            {
                while (Math.Abs(t - c / t) > epsilon * t)
                {
                    t = ((c / t) + t) / 2;
                }
                Console.WriteLine(t);
            }
            else
                Console.WriteLine("Please Enter Non Negative number");
        }
    }
}
