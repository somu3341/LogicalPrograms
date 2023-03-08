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
                Console.WriteLine("1.FibonacciSeries \n2.Perfect Number \n3.Prime Number \n4.Reverse Number \n5.Exit");
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
                        Console.WriteLine("Enter the number");
                        int tum= Convert.ToInt32(Console.ReadLine());
                        PrimeNmber primeNmber = new PrimeNmber();
                        primeNmber.prime(tum);
                        break;
                    case 4:
                        Console.WriteLine("Enter the number");
                        int rum= Convert.ToInt32(Console.ReadLine());
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse(rum);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
