using FluentAssertions;
using static PotterKata.Tests.Book;
using static PotterKata.Tests.ShoppingBasket;

namespace PotterKata.Tests;

public class ShoppingBasketShould
{
    [Test]
    public void CalculatePrice_OfASingleBook()
    {
        PriceOf(Book1).Should().Be(8);
        PriceOf(Book2).Should().Be(8);
        PriceOf(Book3).Should().Be(8);
        PriceOf(Book4).Should().Be(8);
        PriceOf(Book5).Should().Be(8);
    }
}

public static class ShoppingBasket
{
    const float BASE_PRICE = 8f;

    public static float PriceOf(Book book)
    {
        return BASE_PRICE;
    }
}

public record Book
{
    public int Id { get; }

    Book(int id) { Id = id; }
    
    public static Book Book1 => new(1);
    public static Book Book2 => new(2);
    public static Book Book3 => new(3);
    public static Book Book4 => new(4);
    public static Book Book5 => new(5);
}