using SuggestionSOLID.Interfaces;
using SuggestionSOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionSOLID.Suggestions
{
    public class UserProductSuggestion : IProductSuggestion
    {
     
        //logic
        public ProductSuggestionResponse GetProductSuggestion()
        {
            return new ProductSuggestionResponse
            {
                Message = "User Suggestion",
                Products = new List<string> { "Mouse", "Mug" }
            };
        }
    }
}
