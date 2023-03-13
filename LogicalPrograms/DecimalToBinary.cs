using System;
namespace LogicalPrograms
{
    public class DecimalToBinary
    {
        int i;
        public void binary(int num)
        {
            int[]a = new int[num];
            for (i = 0; num >0; i++)
            {
                a[i] = num % 2;
                num = num / 2;
            }
            Console.WriteLine("Binary of the given number: ");
            for (i =i-1; i>=0; i-- ) 
            {
                Console.Write(a[i]);
            }
        }
    }
}
