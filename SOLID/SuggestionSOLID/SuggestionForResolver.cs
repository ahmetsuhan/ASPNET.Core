using SuggestionSOLID.Enums;
using SuggestionSOLID.Interfaces;
using SuggestionSOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static SuggestionSOLID.ProductResolverDelegate;

namespace SuggestionSOLID
{
    public class SuggestionForResolver
    {
        private readonly ProductSuggestionResolver _resolver;
        private readonly IChannelSuggestion _channelSuggestion;

        public SuggestionForResolver(ProductSuggestionResolver resolver, IChannelSuggestion channelSuggestion)
        {
            _resolver = resolver;
            _channelSuggestion = channelSuggestion;
        }

        public void OpenChannel() => _channelSuggestion.OpenSuggestion();
        public void CloseChannel() => _channelSuggestion.CloseSuggestion();


        public ProductSuggestionResponse Suggest(SuggestionType suggestType) => _resolver(suggestType).GetProductSuggestion();
    }
}
