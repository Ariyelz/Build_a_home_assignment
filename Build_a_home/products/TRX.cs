using Build_a_home.interfaces;

namespace Build_a_home.products;

public class TRX : Product, IAssemble,IHomegym
{
    public TRX(string name) : base(name, "TRX", 299)
    {
        
    }
    public string Assemble()
    {
        return "Insert hooks to ceiling, put ropes on hooks, hope that it holds your weight";
    }

    public string Homegym()
    {
        return "You're supposed to use these ropes for your workout, not...";
    }

    public override float Price()
    {
        return _price;
    }

    public override string GetDescription()
    {
        return $" {ProductName}  ropes, hangs from ceiling";
    }

    public override string GetShelf()
    {
        return "Located on shelf 8";
    }
}