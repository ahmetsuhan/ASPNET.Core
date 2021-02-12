using Suggestion.enums;
using Suggestion.Suggestions;
using System;

namespace Suggestion
{
    class Program
    {
        static void Main(string[] args)
        {

            GuestProductSuggestion guestProductSuggestion = new GuestProductSuggestion();
            UserProductSuggestion userProductSuggestion = new UserProductSuggestion();
            GoldUserProductSuggestion goldUserProductSuggestion = new GoldUserProductSuggestion(); 

            Suggestion suggestion = new Suggestion(guestProductSuggestion,userProductSuggestion,goldUserProductSuggestion);

            SuggestionType suggestionType = SuggestionType.Guest;
            suggestion.OpenSuggestionChannel();

            var suggestionResponse = suggestion.Suggest(suggestionType);

            suggestion.CloseSuggestionChannel();

            Console.WriteLine(suggestionResponse.Message);

            suggestionResponse.Products.ForEach(x => Console.WriteLine(x));
        }
    }
}
