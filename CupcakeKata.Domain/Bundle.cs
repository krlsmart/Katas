using System.Text;

namespace CupcakeKata.Domain;

public class Bundle : Cake
{
    readonly List<Cake> cakes = [];
    const float DISCOUNT = 0.9f;
    
    public string Name
    {
        get
        {
            var sb = new StringBuilder("Bundle with ");
            foreach(var product in cakes)
            {
                sb.Append($"1 {product.Name}");
                
                if (product != cakes.Last())
                    sb.Append(" and ");
            }
            
            return sb.ToString();
        }
    }

    public float Price => cakes.Sum(cake => cake.Price) * DISCOUNT;

    
    public Bundle(params Cake[] cakes)
    {
        this.cakes.AddRange(cakes);
    }
}