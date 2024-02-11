using Build_a_home.interfaces;

namespace Build_a_home.products;

public class KingSizeBed : Product, IAssemble, IBedroom
{
    public KingSizeBed(string name) : base(name, "KingSizeBed", 5999)
    {
        
    }
    public string Assemble()
    {
        return "Put one leg on at each corner, then slam the mattress inside the parameters ";
    }

    public string Bedroom()
    {
        return "It's better to sleep alone in a big bed, then to never sleep at all";
    }

    public override float Price()
    {
        return _price;
    }

    public override string GetDescription()
    {
        return $"A lovely {ProductName}, best to buy it right now";
    }

    public override string GetShelf()
    {
        return "Located on shelf 77";
    }
}