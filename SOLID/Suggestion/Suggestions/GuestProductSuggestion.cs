using Suggestion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suggestion.Suggestions
{
    public class GuestProductSuggestion
    {
        //logic
        public ProductSuggestionResponse GetProductsSuggetion()
        {
            return new ProductSuggestionResponse
            {
                Message = "Guest Suggestion",
                Products = new List<string> { "Keyboard", "Headset" }
            };
        }
    }
}
