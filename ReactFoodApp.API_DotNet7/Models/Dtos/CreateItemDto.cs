using System.ComponentModel.DataAnnotations;

namespace ReactFoodApp.API_DotNet7.Models.Dtos;

public class CreateItemDto
{

    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
    public decimal Price { get; set; }

    [Required]
    public string Description { get; set; }

    // Assuming image path or URL can be optional;
    public string Image { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
    public int Quantity { get; set; }
}