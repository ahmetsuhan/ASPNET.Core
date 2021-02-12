using SuggestionSOLID.Enums;
using SuggestionSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionSOLID
{
    public class ProductResolverDelegate
    {
        public delegate IProductSuggestion ProductSuggestionResolver(SuggestionType key);
    }
}
