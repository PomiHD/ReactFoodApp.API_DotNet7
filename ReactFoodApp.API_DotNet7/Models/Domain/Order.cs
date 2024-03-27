using System.ComponentModel.DataAnnotations;

namespace ReactFoodApp.API_DotNet7.Models.Domain;

public class Order
{
    [Key]
    public Guid Id { get; set; }

    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }

    // Define a navigation property for Items
    public List<Item> Items { get; set; } = new List<Item>(); // Initializes the list to prevent null reference exceptions

    // Other properties...
}
