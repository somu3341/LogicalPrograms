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
                Console.WriteLine("1.FibonacciSeries \n2.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}
