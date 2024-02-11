namespace Build_a_home;

public abstract class Product
{
    
    protected string _name;
    protected string ProductName;
    protected float _price;

    protected Product(string name, string productName, float price)
    {
        _name = name;
        ProductName = productName;
        _price = price;
    }

    public abstract string GetShelf();
    public abstract float Price();
    public abstract string GetDescription();
}
