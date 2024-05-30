namespace CqrsKata.Domain;

public interface BookingRepository
{
    Task<IEnumerable<Room>> FreeRooms(DateTime arrival, DateTime departure);
}