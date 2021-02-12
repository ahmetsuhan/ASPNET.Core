using Suggestion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suggestion.Suggestions
{
    public class UserProductSuggestion
    {
        //logic
        public ProductSuggestionResponse GetProductsSuggetion()
        {
            return new ProductSuggestionResponse
            {
                Message = "User Suggestion",
                Products = new List<string> { "Mouse", "Mug" }
            };
        }
    }
}
