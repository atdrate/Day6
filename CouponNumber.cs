﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprogram
{
    internal class CouponNumber
    {
        public static void CouponNo()
        {
            Console.WriteLine("Enter number of coupons");
            int number = int.Parse(Console.ReadLine());
            string coupons = string.Empty;
            while (number > 0)
            {
                int random = new Random().Next(1, 10);
                coupons += random;
                number--;
            }
            Console.WriteLine("Your coupon number is " + coupons);
        }
    }
}
