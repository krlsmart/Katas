namespace CupcakeKata.Domain;

public class Bundle
{
    public string Name { get; init; }
    public float Price { get; init; }
    
    const float DISCOUNT = 0.9f;
    
    public Bundle(Cake cake)
    {
        Name = "Bundle with 1 " + cake.Name;
        Price = cake.Price * DISCOUNT;
    }
}