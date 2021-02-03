using System;
using System.Collections.Generic;
using System.Text;

namespace Extension.Model
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Categorry { get; set; }
        public decimal Price { get; set; }
        public int SellCount { get; set; }
    }
}
