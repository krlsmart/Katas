using CqrsKata.Domain;
using NSubstitute;

namespace CqrsKata.Tests;

[TestFixture]
public class BookingServiceShould
{
    [Test]
    public async Task KnowAllFreeRooms_InADateRange()
    {
        var repositoryMock = Substitute.For<BookingRepository>();
        var sut = new BookingService(repositoryMock);
        var arrival = DateTime.Now;
        var departure = arrival.AddDays(1);
        
        _ = await sut.FreeRooms(arrival, departure);
        
        await repositoryMock.Received(1).FreeRooms(
            Arg.Is<DateTime>(d => d == arrival),
            Arg.Is<DateTime>(d => d == departure)
        );
    }

    [Test]
    public async Task BookARoom()
    {
        var repoMock = Substitute.For<BookingRepository>();
        var sut = new BookingService(repoMock);
        var booking = new Booking();
        
        await sut.BookARoom(booking);
        
        await repoMock.Received(1).BookARoom(Arg.Is<Booking>(b => b == booking));
    }
}