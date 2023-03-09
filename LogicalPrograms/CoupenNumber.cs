using System;
namespace LogicalPrograms
{
    public class CouponNumber
    {
        public void DistinctCoupen(int num)
        {
            int[] arr = new int[500];
            Random random = new Random();
            arr[0] = random.Next(0, num);
            for (int i = 1; i< 10; i++) 
            {
                int coupon = random.Next(0, num);
                for (int j = 1; j< i; j++)
                {
                   if ( arr[j] != coupon)
                        arr[i] = coupon;
                }
                Console.WriteLine("coupon"+i+" "+coupon);
            }
        }
    }
}
