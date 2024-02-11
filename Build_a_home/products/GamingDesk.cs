using System.Net.NetworkInformation;
using Build_a_home.interfaces;

namespace Build_a_home.products;

public class GamingDesk : Product, IAssemble, ILivingroom
{
    public GamingDesk(string name) : base(name,"GamingDesk",5999)
    {
        
    }

    public string Assemble()
    {
        return "Try following the manual without killing your SO in the process";
    }

    public string Livingroom()
    {
        return "This one is a must have for your livingroom";
    }

    public override float Price()
    {
        return _price;
    }

    public override string GetDescription()
    {
        return $"With this {ProductName} you'll never leave your house";
    }

    public override string GetShelf()
    {
        return "Located on shelf 66";
    }
}