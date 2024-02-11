using Build_a_home.interfaces;

namespace Build_a_home.products;

public class Shelf : Product, IAssemble,ILivingroom,IOffice,IBedroom
{
    public Shelf(string name) : base(name, "Shelf", 799)
    {
        
    }
    public string Assemble()
    {
        return "Get one person to hold each long rectangular piece, place the smaller ones inside";
    }

    public string Bedroom()
    {
        return "This shelf is perfect for placing stuff on";
    }

    public string Livingroom()
    {
        return "A shelf that can hold many things";
    }

    public string Office()
    {
        return "When you run out of space for your D&D books";
    }

    public override float Price()
    {
        return _price;
    }

    public override string GetDescription()
    {
        return $"A lovely {ProductName}, onesize fits all";
    }

    public override string GetShelf()
    {
        return "Located on shelf 54";
    }
}