using System;
using System.Collections.Generic;
using System.Text;

namespace SuggestionSOLID.Interfaces
{
    public class ChannelSuggestion : IChannelSuggestion
    {
        public void CloseSuggestion()
        {
            //logic
            Console.WriteLine("Open channel");
        }

        public void OpenSuggestion()
        {
            //logic
            Console.WriteLine("Close channel");

        }
    }
    public interface IChannelSuggestion
    {
        void OpenSuggestion();
        void CloseSuggestion();
    }
}
