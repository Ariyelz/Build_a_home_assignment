using Build_a_home.interfaces;

namespace Build_a_home.products;

public class OfficeDesk : Product, IAssemble,IOffice
{
    public OfficeDesk(string name) : base( name,"OfficeDesk", 3999)
    {
        
    }
    public string Assemble()
    {
        return "Screw the legs to the corners of the rectangular surface, pray that it stands";
    }

    public string Office()
    {
        return "When you have to be 'professional' in front of others";
    }

    public override float Price()
    {
        return _price;
    }

    public override string GetDescription()
    {
        return $"A stale {ProductName}, for when you couldn't buy a gamingdesk";
    }

    public override string GetShelf()
    {
        return "Located on shelf 37";
    }
}