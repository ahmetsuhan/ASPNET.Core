using SuggestionSOLID.Interfaces;
using SuggestionSOLID.Models;

namespace SuggestionSOLID
{
    public class Suggestion
    {

        private readonly IProductSuggestion _productSuggestion;
        private readonly IChannelSuggestion _channelSuggestion;

        public Suggestion(IProductSuggestion productSuggestion,
                            IChannelSuggestion channelSuggestion)
        {
            _productSuggestion = productSuggestion;
            _channelSuggestion = channelSuggestion;
        }
        public void OpenChannel()
        {
            _channelSuggestion.OpenSuggestion();
        }
        public void CloseChannel()
        {
            _channelSuggestion.CloseSuggestion();
        }

        public ProductSuggestionResponse Suggest()
        {
            var response = _productSuggestion.GetProductSuggestion();
            return response;
        }
    }
}
