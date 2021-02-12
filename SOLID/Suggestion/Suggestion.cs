using Suggestion.enums;
using Suggestion.Models;
using Suggestion.Suggestions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suggestion
{
    public class Suggestion
    {

        private readonly GuestProductSuggestion _guestProductSuggestion;
        private readonly UserProductSuggestion _userProductSuggestion;
        private readonly GoldUserProductSuggestion _goldUserProductSuggestion;
        public Suggestion(GuestProductSuggestion guestProductSuggestion,UserProductSuggestion userProductSuggestion,
            GoldUserProductSuggestion goldUserProductSuggestion)
        {
            _guestProductSuggestion = guestProductSuggestion;
            _userProductSuggestion = userProductSuggestion;
            _goldUserProductSuggestion = goldUserProductSuggestion;
        }
        public ProductSuggestionResponse Suggest(SuggestionType suggestionType) //SuggestionType
        {
            ProductSuggestionResponse response = new ProductSuggestionResponse();

            if (suggestionType == SuggestionType.Guest)
            {
                response = _guestProductSuggestion.GetProductsSuggetion();

            }
            else if (suggestionType == SuggestionType.User)
            {
                response = _userProductSuggestion.GetProductsSuggetion();
            }else if(suggestionType == SuggestionType.GoldUser)
            {
                response = _goldUserProductSuggestion.GetProductsSuggetion();
            }
            else
            {
                throw new NotImplementedException();
            }
            return response;
        }
        public void OpenSuggestionChannel()
        {
            Console.WriteLine("Channel opened");

        }

        public void CloseSuggestionChannel()
        {
            Console.WriteLine("Channel closed");

        }

    }
}
