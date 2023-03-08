using System;
namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void perfect(int sam)
        {
            int check = 0;
            for (int a = 1; a < sam; a++)
            {
                if (sam % a == 0)
                    check += a;
            }
            if (check == sam)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not a Perfect Number");
        }
    }
}

