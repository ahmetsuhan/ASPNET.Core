using Extension.Model;
using Extension.TypeExtension;
using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region String Extensions

            string variable1 = "Ahmet suhan oka";

            if (variable1.IsEmpty())
            {

            }
            if (variable1.IsFilled())
            {

            }
            if (string.IsNullOrEmpty(variable1))
            {

            }
            #endregion String Extensions


            int number1 = 5;
            if (number1.InRange(5, 10))
            {
                Console.WriteLine("Aynen InRange :)");
            }
            if (number1.NotInRange(10, 50))
            {
                Console.WriteLine("Aynen not in range :)");
            }

            int num2 = 8;
            int num3 = num2.ConvertToCrossRate();
            Console.WriteLine("num2: " + num2);
            Console.WriteLine("num3: " + num3);



            int num4 = 13;


            Console.WriteLine(num4.IsPrimeNumber());



            List<Product> productList = new List<Product>()
            {
              new Product  { Id=1,Name="Phone", SellCount=12,DiscountedPrice=698745,Price=698745 },
              new Product  { Id=2,Name="Television", SellCount=123,DiscountedPrice=147,Price=147 },
              new Product  { Id=3,Name="Coffee", SellCount=414,DiscountedPrice=1344,Price=1344 },
              new Product  { Id=4,Name="Tree", SellCount=123,DiscountedPrice=1,Price=1 },
              new Product  { Id=5,Name="Cup", SellCount=123,DiscountedPrice=724,Price=724 },
              new Product  { Id=6,Name="Cheetos", SellCount=12,DiscountedPrice=561,Price=561 },
              new Product  { Id=7,Name="Cure", SellCount=145,DiscountedPrice=123,Price=123 },

            };

            productList.ApplyBestSellerDiscount();


            List<Product> productItems = new List<Product>();
            productItems.Add(new Product { Id = 1, Name = "Phone", Price = 1500, DiscountedPrice = 1500, SellCount = 50 });
            productItems.Add(new Product { Id = 2, Name = "Tv", Price = 100, DiscountedPrice = 100, SellCount = 100 });
            var resItem = productItems.ConvertProductToProductDto();



            List<ProductDto> productDtoList = new List<ProductDto>()
            {
              new ProductDto  { Id=1,Name="Phone", SellCount=12,Categorry="A",Price=698745 },
              new ProductDto  { Id=2,Name="Television", SellCount=123,Categorry="B",Price=147 },
              new ProductDto  { Id=3,Name="Coffee", SellCount=414,Categorry="C",Price=1344 },
              new ProductDto  { Id=4,Name="Tree", SellCount=123,Categorry="C",Price=1 },
              new ProductDto  { Id=5,Name="Cup", SellCount=123,Categorry="C",Price=724 },
              new ProductDto  { Id=6,Name="Cheetos", SellCount=12,Categorry="C",Price=561 },
              new ProductDto  { Id=7,Name="Cure", SellCount=145,Categorry="C",Price=123 },

            };
            var resItem2 = productDtoList.ConvertProductDtoToProductLinq();

            Console.ReadKey();
        }
    }
}
