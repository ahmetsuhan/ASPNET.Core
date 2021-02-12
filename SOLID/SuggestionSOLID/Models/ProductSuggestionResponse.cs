using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionSOLID.Models
{
    public class ProductSuggestionResponse
    {
        public string Message { get; set; }
        public List<string> Products { get; set; }
    }
}
