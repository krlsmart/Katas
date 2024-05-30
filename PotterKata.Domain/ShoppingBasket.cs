namespace PotterKata.Domain;

public static class ShoppingBasket
{
    const float BASE_PRICE = 8f;

    public static float PriceOf(params Book[] book)
    {
        var distinctBooks = book.Distinct().Count();
        var equalBooks = book.Length - distinctBooks;
        
        return PriceOfEqualBooks(equalBooks) + PriceOfDistinctBooks(distinctBooks);
    }

    static float PriceOfEqualBooks(int equalBooks)
        => BASE_PRICE * equalBooks;

    static float PriceOfDistinctBooks(int distinctBooks)
        => BASE_PRICE * distinctBooks * GetDiscountFor(distinctBooks);

    static float GetDiscountFor(int distinctBooks)
        => distinctBooks switch
        {
            2 => 0.95f,
            3 => 0.90f,
            4 => 0.80f,
            5 => 0.75f,
            _ => 1
        };
}