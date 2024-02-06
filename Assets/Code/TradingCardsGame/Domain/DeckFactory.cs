using System.Collections.Generic;
using System.Linq;

namespace TradingCards.Domain
{
    public class DeckFactory
    {
        public const int StartingDeckSize = 20;
        public readonly static int[] StartingDeckDistribution = new int[]{ 2, 2, 3, 4, 3, 2, 2, 1, 1 };

        public static PlayerDeck StartingDeck()
        {
            var cards = new List<Card>(StartingDeckSize);
            for(var i = 0; i < StartingDeckDistribution.Length; i++)
                cards.AddRange(CreateCardsByManaCost(i, StartingDeckDistribution[i]));

            return new PlayerDeck() { Cards = cards };
        }

        static IEnumerable<Card> CreateCardsByManaCost(int manaCost, int howMany)
        {
            return Enumerable.Range(0, howMany)
                .Select(c => new Card 
                {
                    Damage = manaCost,
                    ManaCost = manaCost
                });
        }
    }
}
