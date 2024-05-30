using CqrsKata.Domain;
using NSubstitute;

namespace CqrsKata.Tests;

public class BookingServiceShould
{
    [Test]
    public async Task KnowAllFreeRooms()
    {
        var repositoryMock = Substitute.For<BookingRepository>();
        var sut = new Booking(repositoryMock);
        
        _ = await sut.FreeRooms();
        
        await repositoryMock.Received(1).FreeRooms();
    }
}