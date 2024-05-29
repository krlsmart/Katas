namespace CupcakeKata.Domain;

public class Cupcake
{
    public string Name { get; }
    public float Price { get; }

    public Cupcake()
    {
        Name = "Cupcake";
        Price = 1f;
    }
}

public class Chocolate
{
    public string Name { get; }
    public float Price { get; }

    public Chocolate(Cupcake cupcake)
    {
        Name = cupcake.Name + " with Chocolate";
        Price = cupcake.Price + 0.1f;
    }
}

public class Peanut
{
    public string Name { get; }
    public float Price { get; }

    public Peanut(Chocolate topping)
    {
        Name = topping.Name + " and Peanut";
        Price = topping.Price + 0.2f;
    }
}
