using Extension.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension.TypeExtension
{
    public static class DiscountExtension
    {
        
        public static void ApplyBestSellerDiscount(this List<Product> products)
        {
            var bestSeller = products.OrderByDescending(p => p.SellCount).FirstOrDefault();
            bestSeller.DiscountedPrice = (bestSeller.Price * 10 / 100);

        }

       
    }
}
