using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class MinimumDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            decimal totalWithDiscount = totalParam;
           if (totalParam < 0)
           {
                throw new ArgumentOutOfRangeException();
            }
            else if(totalParam >=10 && totalParam <= 100)
           {
               totalWithDiscount = totalParam - 5M;
            }
           else if(totalParam > 100)
            {
                totalWithDiscount = totalParam * 0.9M;
            }
            return totalWithDiscount;
        }
    }
}