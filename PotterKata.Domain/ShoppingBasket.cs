namespace PotterKata.Domain;

public static class ShoppingBasket
{
    const float BASE_PRICE = 8f;

    public static float PriceOf(params Book[] book)
    {
        var distinctBooks = book.Distinct().Count();
        return BASE_PRICE * distinctBooks * GetDiscountFor(distinctBooks);
    }

    static float GetDiscountFor(int distinctBooks)
    {
        return distinctBooks switch
        {
            2 => 0.95f,
            3 => 0.90f,
            4 => 0.80f,
            5 => 0.75f,
            _ => 1
        };
    }
}