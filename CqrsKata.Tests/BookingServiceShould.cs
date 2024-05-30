using CqrsKata.Domain;
using NSubstitute;

namespace CqrsKata.Tests;

public class BookingServiceShould
{
    [Test]
    public async Task KnowAllFreeRooms_InADateRange()
    {
        var repositoryMock = Substitute.For<BookingRepository>();
        var sut = new Booking(repositoryMock);
        var arrival = DateTime.Now;
        var departure = arrival.AddDays(1);
        
        _ = await sut.FreeRooms(arrival, departure);
        
        await repositoryMock.Received(1).FreeRooms(
            Arg.Is<DateTime>(d => d == arrival),
            Arg.Is<DateTime>(d => d == departure)
        );
    }
}