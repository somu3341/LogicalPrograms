using System;
namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reverse(int value)
        {
            int result = 0;
            while (value > 0)
            {
                int remainder = value % 10;
                result = result * 10 + remainder;
                value /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
