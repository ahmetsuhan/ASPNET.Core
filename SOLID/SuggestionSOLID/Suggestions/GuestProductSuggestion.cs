using SuggestionSOLID.Interfaces;
using SuggestionSOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionSOLID.Suggestions
{
    public class GuestProductSuggestion:IProductSuggestion
    {
        //logic
        public ProductSuggestionResponse GetProductSuggestion()
        {
            return new ProductSuggestionResponse
            {
                Message = "Guest Suggestion",
                Products = new List<string> { "Keyboard", "Headset" }
            };
        }
    }
}
