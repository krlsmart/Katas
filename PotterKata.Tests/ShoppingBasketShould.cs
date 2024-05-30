using FluentAssertions;
using static PotterKata.Domain.Book;
using static PotterKata.Domain.ShoppingBasket;

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
    
    [Test]
    public void ApplyDiscount_WhenBuyingDifferentBooks()
    {
        PriceOf(Book1, Book2).Should().Be(8 * 2 * 0.95f);
        PriceOf(Book1, Book2, Book3).Should().Be(8 * 3 * 0.90f);
        PriceOf(Book1, Book2, Book3, Book4).Should().Be(8 * 4 * 0.80f);
        PriceOf(Book1, Book2, Book3, Book4, Book5).Should().Be(8 * 5 * 0.75f);
    }
}