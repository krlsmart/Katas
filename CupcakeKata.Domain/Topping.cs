namespace CupcakeKata.Domain;

public abstract class Topping : Cake
{
    public string Name { get; }
    public float Price { get; }
    
    protected abstract string ToppingName { get; }
    protected abstract float ToppingPrice { get; }

    protected Topping(Cake cake)
    {
        Name = cake.Name + $" with {ToppingName}";
        Price = cake.Price + ToppingPrice;
    }

    protected Topping(Topping cake)
    {
        Name = cake.Name + $" and {ToppingName}";
        Price = cake.Price + ToppingPrice;
    }
}

public sealed class Chocolate : Topping
{
    protected override string ToppingName => "Chocolate";
    protected override float ToppingPrice => 0.1f;

    public Chocolate(Cake cake) : base(cake) { }
    public Chocolate(Topping cake) : base(cake) { }
}

public sealed class Peanut : Topping
{
    protected override string ToppingName => "Peanut";
    protected override float ToppingPrice => 0.2f;
    
    public Peanut(Cake cake) : base(cake) { }
    public Peanut(Topping cake) : base(cake) { }
}