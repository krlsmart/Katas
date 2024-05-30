namespace CqrsKata.Domain;

public record Booking
{
    public Guid ClientId { get; }
    public string RoomName { get; }
    public DateTime Arrival { get; }
    public DateTime Departure { get; }

    public Booking()
    {
        ClientId = Guid.NewGuid();
        RoomName = string.Empty;
        Arrival = DateTime.Now;
        Departure = Arrival.AddDays(1);
    }
}