using FluentAssertions;
using static PotterKata.Domain.Book;
using static PotterKata.Domain.ShoppingBasketHelper;

namespace PotterKata.Tests;

public class ShoppingBasketHelperShould
{
    [Test]
    public void Obtain_RepeatedBooks()
    {
        RepeatedBooksOf(new[] { Book1, Book1, Book2, Book2, Book3, Book4 })
            .Should().BeEquivalentTo(new[] { Book1, Book1, Book2, Book2 });
    }
    
    [Test]
    public void Obtain_NotRepeatedBooks()
    {
        NotRepeatedBooksOf(new[] { Book1, Book1, Book2, Book2, Book3, Book4 })
            .Should().BeEquivalentTo(new[] { Book3, Book4 });
    }
    
}