using System;
namespace LogicalPrograms
{
    class Program
    {
        public static void Main(string[] args) 
        {
            bool flag = true;
            while (flag) 
            {
                Console.WriteLine("1.FibonacciSeries \n2.Perfect Number \n3.Exit");
                Console.WriteLine("Enter option which need's to be Executed");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) 
                {
                    case 1:
                        Console.WriteLine("Enter the Number");
                        int num= Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries series = new FibonacciSeries();
                        series.PrintSeries(num);
                        break;
                        case 2:
                        Console.WriteLine("Enter the number");
                        int sum = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.perfect(sum);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
