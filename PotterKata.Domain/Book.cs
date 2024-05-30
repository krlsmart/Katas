namespace PotterKata.Domain;

public record Book
{
    public int Id { get; }

    Book(int id) { Id = id; }
    
    public static Book Book1 => new(1);
    public static Book Book2 => new(2);
    public static Book Book3 => new(3);
    public static Book Book4 => new(4);
    public static Book Book5 => new(5);
}