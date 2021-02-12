using SuggestionSOLID.Interfaces;
using SuggestionSOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionSOLID.Suggestions
{
    public class GoldUserProductSuggestion:IProductSuggestion
    {
        //logic
        public ProductSuggestionResponse GetProductSuggestion()
        {
            return new ProductSuggestionResponse
            {
                Message = "GoldUser Suggestion",
                Products = new List<string> { "Car", "Special Computers" }
            };
        }

       
    }
}
