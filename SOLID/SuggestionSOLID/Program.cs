using Microsoft.Extensions.DependencyInjection;
using SuggestionSOLID.Enums;
using SuggestionSOLID.Interfaces;
using SuggestionSOLID.Suggestions;
using System;
using System.Linq;
using static SuggestionSOLID.ProductResolverDelegate;

namespace SuggestionSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FindServiceCustomize
            var serviceProvider = new ServiceCollection().
               AddTransient<IProductSuggestion, GuestProductSuggestion>()
               .AddTransient<IProductSuggestion, UserProductSuggestion>()
               .AddTransient<IProductSuggestion, GoldUserProductSuggestion>()
               .AddTransient<IChannelSuggestion, ChannelSuggestion>()
               .BuildServiceProvider();

            var suggestionType = SuggestionType.Guest;
            IProductSuggestion productSuggestion = null;
            IChannelSuggestion channelSuggestion = null;
            var serviceIProducts = serviceProvider.GetServices<IProductSuggestion>();
            switch (suggestionType)
            {
                case SuggestionType.None:
                    break;
                case SuggestionType.Guest:
                    productSuggestion = serviceIProducts.First(x => x.GetType() == typeof(GuestProductSuggestion));
                    break;
                case SuggestionType.User:
                    productSuggestion = serviceIProducts.First(x => x.GetType() == typeof(UserProductSuggestion));
                    break;
                case SuggestionType.GoldUser:
                    productSuggestion = serviceIProducts.First(x => x.GetType() == typeof(GoldUserProductSuggestion));
                    break;
                default:
                    break;
            }
            channelSuggestion = serviceProvider.GetService<IChannelSuggestion>();
            Suggestion suggestion = new Suggestion(productSuggestion, channelSuggestion);

            suggestion.OpenChannel();
            var sug = suggestion.Suggest();
            Console.WriteLine(sug.Message);
            sug.Products.ForEach(x => Console.WriteLine(x));
            suggestion.CloseChannel();
            #endregion FindServiceCustomize



            #region FinServiceResolver
            //setup our DI
            var serviceProviderCollection = new ServiceCollection()
                  .AddTransient<GuestProductSuggestion>()
                  .AddTransient<UserProductSuggestion>()
                  .AddTransient<SuggestionForResolver>()
                  .AddTransient<IChannelSuggestion, ChannelSuggestion>();

            serviceProviderCollection.AddTransient<ProductSuggestionResolver>(suggestProvider => key =>
            {
                switch (key)
                {
                    case SuggestionType.User:
                        return suggestProvider.GetService<UserProductSuggestion>();
                    case SuggestionType.Guest:
                        return suggestProvider.GetService<GuestProductSuggestion>();
                    case SuggestionType.None:
                        throw new NotImplementedException();
                    default:
                        throw new NotImplementedException();
                }
            });

            var resolveMapping = ((ServiceProvider)serviceProviderCollection.BuildServiceProvider())
                .GetRequiredService<SuggestionForResolver>();

            resolveMapping.OpenChannel();
            var res = resolveMapping.Suggest(SuggestionType.Guest);

            Console.WriteLine(res.Message);
            res.Products.ForEach(x => Console.WriteLine(x));

            resolveMapping.CloseChannel();


            #endregion FinServiceResolver
        }
    }
}
