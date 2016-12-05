using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class LinqValueCalculator:IValueCalculator
    {
        private IDiscountHelper discounter;
        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discounter = discountParam;
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            decimal productsSum = products.Sum(p => p.Price);
            decimal productsDiscount = discounter.ApplyDiscount(productsSum);
            return productsDiscount;
        }
    }
}