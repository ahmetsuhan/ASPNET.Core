using System;
using System.Collections.Generic;
using System.Text;

namespace Suggestion.Models
{
    public class ProductSuggestionResponse
    {
        public string Message { get; set; }
        public List<string> Products { get; set; }
    }
}
