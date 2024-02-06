using System.Collections.Generic;

namespace TradingCards.Domain
{
    public static class DeckFactory
    {
        const int StartingDeckSize = 30;

        public static PlayerDeck StartingDeck()
        {
            var cards = new List<Card>(StartingDeckSize);
            for(var i = 0; i < StartingDeckSize; i++)
                cards.Add(new Card());

            return new PlayerDeck() { Cards = cards };
        }
    }
}
