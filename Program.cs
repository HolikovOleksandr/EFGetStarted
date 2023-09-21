using EFGetStarted.Data;
using EFGetStarted.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using AwesomePizzaContext context = new AwesomePizzaContext();

        Product firstAwesomePizza = new Product
        {
            Name = "First Awesome Pizza",
            Price = 299.99M,
        };
        context.Products.Add(firstAwesomePizza);

        Product secondAwesomePizza = new Product
        {
            Name = "Second Awesome Pizza",
            Price = 199.99M,
        };
        context.Products.Add(secondAwesomePizza);

        context.SaveChanges();
    }
}