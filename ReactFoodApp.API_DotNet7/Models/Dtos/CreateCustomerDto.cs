using System.ComponentModel.DataAnnotations;

namespace ReactFoodApp.API_DotNet7.Models.Dtos;

public class CreateCustomerDto
{
    [Required]
    [StringLength(20, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 20 characters")]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "Street must be between 1 and 100 characters")]
    public string Street { get; set; }

    [Required]
    [StringLength(20, MinimumLength = 4, ErrorMessage = "Postal code must be between 4 and 20 characters")]
    public string PostalCode { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "City must be between 1 and 50 characters")]
    public string City { get; set; }
}