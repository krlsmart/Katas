using System.Collections.Generic;

namespace TradingCards.Domain
{
    public class PlayerDeck
    {
        internal IEnumerable<Card> Cards { get; init; }
    }
}
