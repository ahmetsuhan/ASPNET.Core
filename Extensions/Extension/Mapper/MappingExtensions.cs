using Extension.Model;
using System.Collections.Generic;
using System.Linq;

namespace Extension.TypeExtension
{
    public static class MappingExtensions
    {

        public static List<ProductDto> ConvertProductToProductDto(this List<Product> products)
        {
            List<ProductDto> productDtos = new List<ProductDto>();
            for(int i = 0; i < products.Count; i++)
            {
                productDtos[i].Id = products[i].Id;
                productDtos[i].Name = products[i].Name;
                productDtos[i].Price = products[i].Price;
                
            }
            return productDtos;
        }

        public static List<ProductDto> ConvertProductToProductDtoLinq(this List<Product> products)
        {
            return products.Select(p=> new ProductDto 
            { 
            Id=p.Id,
            Name=p.Name,
            Price=p.Price,
           SellCount=p.SellCount 
            }).ToList();
        }


        public static List<Product> ConvertProductDtoToProduct(this List<ProductDto> productDtos)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                products[i].Id = productDtos[i].Id;
                products[i].Name = productDtos[i].Name;
                products[i].Price = productDtos[i].Price;
                products[i].DiscountedPrice = productDtos[i].Price;
            }
            return products;
        }



        public static List<Product> ConvertProductDtoToProductLinq(this List<ProductDto> productDtos)
        {
            return productDtos.Select(p=> new Product 
            { 
                Id=p.Id,
                Name=p.Name,
                Price=p.Price,
                DiscountedPrice=p.Price,
                SellCount=p.SellCount
            
            }).ToList();
        }


        /*Foreach ile  */
        public static List<Product> ConvertProductDtoToProductForeach(this List<ProductDto> productDtos)
        {
            List<Product> products = new List<Product>();
            foreach (var item in productDtos)
            {
                products.Add(new Product
                { 
                    Id=item.Id,
                    Name=item.Name,
                    Price=item.Price,
                    SellCount=item.SellCount
                });
            }
            return products;
        }
    }
}
