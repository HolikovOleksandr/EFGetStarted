namespace EFGetStarted.Models;

public class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Adress { get; set; }

    public string? Phone { get; set; }

    public ICollection<Order> Orders { get; set; } = null!;
}
