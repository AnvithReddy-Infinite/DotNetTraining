using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
 
        static class Pricing
        {
            public static decimal CalculateGST(decimal amount) => amount * 0.18M;

            public static bool TryGetWeekendSurcharge(DateTime date, out decimal percent)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    percent = 20;
                    return true;
                }
                percent = 0;
                return false;
            }

            public static decimal AddOnsCost(params string[] addOns)
            {
                decimal cost = 0;
                foreach (var addon in addOns)
                {
                    switch (addon.Trim().ToLower())
                    {
                        case "child-seat": cost += 100; break;
                        case "fast-tag": cost += 75; break;
                        case "priority-pickup": cost += 80; break;
                        case "extra-luggage": cost += 120; break;
                    }
                }
                return cost;
            }

            // Call by value demonstration
            public static decimal TryApplyCoupon_ByValue(decimal total, decimal couponAmount)
            {
                if (couponAmount > 0 && couponAmount < total)
                    return total - couponAmount;
                return total;
            }

            // Coupon by reference, with out
            public static void ApplyCoupon_ByRef(ref decimal total, decimal couponAmount, out decimal applied)
            {
                applied = 0;
                if (couponAmount > 0 && couponAmount < total)
                {
                    total -= couponAmount;
                    applied = couponAmount;
                }
            }

            // Loyalty by ref, with out
            public static void RedeemLoyalty(ref int points, ref decimal total, out int applied)
            {
                applied = 0;
                int toRedeem = points >= 100 ? 100 : points;
                if (toRedeem > 0)
                {
                    total -= toRedeem;
                    applied = toRedeem;
                    points -= toRedeem;
                }
            }
        }
}
