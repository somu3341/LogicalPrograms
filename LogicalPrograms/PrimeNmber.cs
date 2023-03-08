using System;
namespace LogicalPrograms
{
    internal class PrimeNmber
    {
        public void prime(int num)
        {
            int flat = 0;
           for (int i = 2; i < num/2; i++)
           {
                if (num % i == 0)
                {
                    Console.WriteLine("It is not a prime number");
                    flat = 1;
                    break;
                }  
           }
           if(flat == 0)
            Console.WriteLine("It is prime number");
        }
    }
}
