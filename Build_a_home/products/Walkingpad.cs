using Build_a_home.interfaces;

namespace Build_a_home.products;

public class Walkingpad : Product, IAssemble, IHomegym
{
    public Walkingpad(string name) : base(name, "Walkinggpad", 12600)
    {
        
    }
    public string Assemble()
    {
        return "Fold in, fold out";
    }

    public string Homegym()
    {
        return "Walk 500 miles, then walk 500 more, trallalala";
    }

    public override float Price()
    {
        return _price;
    }

    public override string GetDescription()
    {
        return $"A walk on a {ProductName}, keeps you warm ";
    }

    public override string GetShelf()
    {
        return "Located on shelf 87";
    }
}