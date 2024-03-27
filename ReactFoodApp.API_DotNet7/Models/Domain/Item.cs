namespace ReactFoodApp.API_DotNet7.Models.Domain;

public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public int Quantity { get; set; }
}