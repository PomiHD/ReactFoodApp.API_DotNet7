using System.ComponentModel.DataAnnotations;

namespace ReactFoodApp.API_DotNet7.Models.Dtos;

public class CreateOrderDto
{
    [Required]
    public List<CreateItemDto> Items { get; set; } = new List<CreateItemDto>();

    [Required]
    public CreateCustomerDto Customer { get; set; }
}
