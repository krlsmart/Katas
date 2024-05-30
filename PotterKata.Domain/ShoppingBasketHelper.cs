namespace PotterKata.Domain;

public class ShoppingBasketHelper
{
    public static IEnumerable<Book> RepeatedBooksOf(IEnumerable<Book> books)
    {
        var distinctBooks = NotRepeatedBooksOf(books);
        var booksCopy = new List<Book>(books);

        foreach(var book in distinctBooks) 
            booksCopy.Remove(book);
        
        return booksCopy;
    }
    
    public static IEnumerable<Book> NotRepeatedBooksOf(IEnumerable<Book> books)
    {
        return books.GroupBy(b => b)
            .Where(g => g.Count() == 1)
            .Select(g => g.Key);
    }
}