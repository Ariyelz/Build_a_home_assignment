using Build_a_home.interfaces;

namespace Build_a_home.products;

public class BeanBag : Product, ILivingroom, IAssemble
{
    public BeanBag(string name) : base(name,"BeanBag", 469)
    {
        
    }
    public string Assemble()
    {
        return "Nothing to assemble, but be careful not to poke a hole in it";
    }

    public string Livingroom()
    {
        return "Cause why not buy a BeanBag to go with your nintendo switch?";
    }

    public override float Price()
    {
        return _price;
    }

    public override string GetDescription()
    {
        return $"A squishy, squoshy, comfy beanbag";
    }

    public override string GetShelf()
    {
        return "Located on shelf 98";
    }
}