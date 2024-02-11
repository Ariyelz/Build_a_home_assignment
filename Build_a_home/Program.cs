using Build_a_home.interfaces;
using Build_a_home.products;

namespace Build_a_home;

class Program
{
    static void Main(string[] args)
    {
        //prøver å lage liste med produkter..
        List<Product> products = new List<Product>();

        products.Add(new GamingDesk("Buer"));
        products.Add(new Walkingpad("Morax"));
        products.Add(new Shelf("Focalore"));
        products.Add(new TRX("Baal"));
        products.Add(new BeanBag("Barbatos"));
        products.Add(new Wallpaper("Witcher"));
        products.Add(new OfficeDesk("Astaroth"));

        // Tell antall produkter som tilhører stuen
        int livingRoomProductsCount = CountLivingRoomProducts(products);

        // Skriv ut detaljene om produktene som tilhører stuen
        PrintLivingRoomProducts(products);

        // Vis resultatet
        Console.WriteLine($"Number of products assigned to livingroom: {livingRoomProductsCount}");
    }

    static int CountLivingRoomProducts(List<Product> products)
    {
        int count = 0;
        foreach (Product product in products)
        {
            // Sjekk om produktet tilhører stuen ved å se om det implementerer ILivingRoom-interface
            if (product is ILivingroom)
            {
                count++;
            }
        }

        return count;
    }

    static void PrintLivingRoomProducts(List<Product> products)
    {
        Console.WriteLine("Produkter som tilhører stuen:");
        foreach (Product product in products)
        {
            // Sjekk om produktet tilhører stuen ved å se om det implementerer ILivingRoom-interface
            if (product is ILivingroom)
            {
                Console.WriteLine($"Price: {product.Price()}");
                Console.WriteLine($"Description: {product.GetDescription()}");
                Console.WriteLine($"Function for livingroom: {((ILivingroom)product).Livingroom()}");
                Console.WriteLine($"Shelf: {product.GetShelf()}");
                Console.WriteLine();
            }
        }

    }
}