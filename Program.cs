using EFGetStarted.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        using AwesomePizzaContext context = new AwesomePizzaContext();

        var products = context.Products
            .Where(p => p.Price > 1M)
            .OrderBy(p => p.Name);

        foreach (var p in products)
        {
            Console.WriteLine("Id: " + p.Id);
            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("Price: " + p.Price);
            Console.WriteLine(new string('~', 15));
            Console.WriteLine(string.Empty);
        }
    }
}