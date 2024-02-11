namespace Build_a_home;

public abstract class Product
{
    private string _name;
    private float _price;

    protected Product(string name, float price)
    {
        _name = name;
        _price = price;
    }

    public abstract string GetShelf();
    public abstract float Price();
    public abstract string GetDescription();
}
