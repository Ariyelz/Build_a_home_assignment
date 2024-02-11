using Build_a_home.interfaces;

namespace Build_a_home.products;

public class Wallpaper : Product, ILivingroom
{
    public Wallpaper(string name) : base(name, "Wallpaper", 99)
    {
        
    }
    

    public string Livingroom()
    {
        return "The perfect picture";
    }

    public override float Price()
    {
        return _price;
    }

    public override string GetDescription()
    {
        return $"A  {ProductName}, picturing Imlretih, Eredin and Caranthir";
    }

    public override string GetShelf()
    {
        return "Located on shelf 1";
    }
}