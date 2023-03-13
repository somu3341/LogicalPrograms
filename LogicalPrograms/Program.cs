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
                Console.WriteLine("\n1.FibonacciSeries \n2.Perfect Number \n3.Prime Number \n4.Reverse Number " +
                    "\n5.Day of Week \n6.Temperature Conversion \n7.Monthaly Payment \n8.Coupen Number " +
                    "\n9. Stop Watch \n10.VendingMachine \n11.Square Root \n12.Decimal to Binary \n13.Exit");
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
                        Console.WriteLine("Enter Date");
                        int day= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter month");
                        int month= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter year");
                        int year= Convert.ToInt32(Console.ReadLine());
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.week(day,month,year);
                        break; 
                        case 6:
                        Console.WriteLine("Select Option 1.Celsius to Fahrenheit 2.Fahrenheit to  Celsius ");
                        int cel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Enter Temperature Value");
                        int feh = Convert.ToInt32(Console.ReadLine());
                        Temperature temperature = new Temperature();
                        temperature.degree(cel, feh);
                        break;
                    case 7:
                        Console.WriteLine("Enter P Value");
                        int P=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Y value");
                        int Y=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter R value");
                        int R=Convert.ToInt32(Console.ReadLine());
                        MonthlyPayment monthlyPayment = new MonthlyPayment();
                        monthlyPayment.payment(P, Y, R);
                        break;
                        case 8:
                        Console.WriteLine("Enter number");
                        int mum= Convert.ToInt32(Console.ReadLine());
                        CouponNumber coupenNumber = new CouponNumber();
                        coupenNumber.DistinctCoupen(mum);
                        break;
                    case 9:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.Run();
                        break;
                        case 10:
                        Console.WriteLine("Enter a amount");
                        int vend=Convert.ToInt32(Console.ReadLine());
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.changereturned(vend);
                        break;
                        case 11:
                        Console.WriteLine("Enter a amount");
                        int root = Convert.ToInt32(Console.ReadLine());
                        SquareRoot squareRoot = new SquareRoot();
                        squareRoot.newton(root);
                        break;
                        case 12:
                        Console.WriteLine("Enter a number to be convert from decimal to binary");
                        int bin=Convert.ToInt32(Console.ReadLine());
                        DecimalToBinary decimalToBinary = new DecimalToBinary();
                        decimalToBinary.binary(bin);
                        break;
                    case 13:
                        flag = false;
                        break;
                }
            }
        }
    }
}
