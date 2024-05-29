namespace CupcakeKata.Domain;

public interface Cake
{
    string Name { get; }
    float Price { get; }
}

public class Cupcake : Cake
{
    public string Name { get; }
    public float Price { get; }

    public Cupcake()
    {
        Name = "Cupcake";
        Price = 1f;
    }
}

public class Chocolate : Cake
{
    public string Name { get; }
    public float Price { get; }

    public Chocolate(Cake cupcake)
    {
        Name = cupcake.Name + " with Chocolate";
        Price = cupcake.Price + 0.1f;
    }
}

public class Peanut : Cake
{
    public string Name { get; }
    public float Price { get; }

    public Peanut(Cake topping)
    {
        Name = topping.Name + " and Peanut";
        Price = topping.Price + 0.2f;
    }
}
