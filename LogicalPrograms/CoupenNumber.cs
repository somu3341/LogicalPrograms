using System;
namespace LogicalPrograms
{
    public class CoupenNumber
    {
        public void DistinctCoupen(int num)
        {
            int[] arr = new int[10];
            Random random = new Random();
            arr[0] = random.Next(0, num);
            for (int i = 1; i< 10; i++) 
            {
                int coupen = random.Next(0, num);
                for (int j = 1; j< i; j++)
                {
                   if ( arr[j] != coupen)
                        arr[i] = coupen;
                }
                Console.WriteLine(coupen);
            }
        }
    }
}
