namespace PotterKata.Domain;

public static class ShoppingBasket
{
    const float BASE_PRICE = 8f;
    
    public static float PriceOf(params Book[] books)
    {
        var bookGroups = new List<List<Book>> { new() };
        DistributeRepeatedBooksInDifferentGroups();
        DistributeNotRepeatedBooks();
        return bookGroups.Sum(g => PriceOfDistinctBooks(g.Count));
        
        
        void DistributeRepeatedBooksInDifferentGroups()
        {
            foreach(var book in ShoppingBasketHelper.RepeatedBooksOf(books))
            {
                if(bookGroups.Any(g => !g.Contains(book)))
                    bookGroups.First(g => !g.Contains(book)).Add(book);
                else
                    bookGroups.Add(new() { book });
            }
        }

        void DistributeNotRepeatedBooks()
        {
            foreach(var book in ShoppingBasketHelper.NotRepeatedBooksOf(books))
                bookGroups.OrderBy(g => g.Count).First().Add(book);
        }
    }

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