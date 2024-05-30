namespace CqrsKata.Domain;

public class Booking
{
    readonly BookingRepository repo;

    public Booking(BookingRepository repo)
    {
        this.repo = repo;
    }

    public Task<IEnumerable<Room>> FreeRooms(DateTime arrival, DateTime departure)
        => repo.FreeRooms(arrival, departure);
}