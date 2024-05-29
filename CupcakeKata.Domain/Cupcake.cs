namespace CupcakeKata.Domain;

public class Cupcake
{
    public string Name { get; }
    public float Price { get; set; }

    public Cupcake()
    {
        Name = "Cupcake";
        Price = 1f;
    }
}