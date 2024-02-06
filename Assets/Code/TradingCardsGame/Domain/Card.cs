namespace TradingCards.Domain
{
    public readonly struct Card
    {
        public readonly int Damage { get; init; }
        public readonly int ManaCost { get; init; }
    }
}
