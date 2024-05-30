namespace CqrsKata.Domain;

public class BookingService
{
    readonly BookingRepository repo;

    public BookingService(BookingRepository repo)
    {
        this.repo = repo;
    }

    public Task<IEnumerable<Room>> FreeRooms(DateTime arrival, DateTime departure)
        => repo.FreeRooms(arrival, departure);

    public Task BookARoom(Booking booking)
        => repo.BookARoom(booking);
}