using Suggestion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suggestion.Suggestions
{
    public class GoldUserProductSuggestion
    {
        //logic
        public ProductSuggestionResponse GetProductsSuggetion()
        {
            return new ProductSuggestionResponse
            {
                Message = "GoldUser Suggestion",
                Products = new List<string> { "Car", "Special Computers" }
            };
        }
    }
}
