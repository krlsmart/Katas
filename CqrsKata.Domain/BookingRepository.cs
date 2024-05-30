namespace CqrsKata.Domain;

public interface BookingRepository
{
    Task<IEnumerable<Room>> FreeRooms();
}