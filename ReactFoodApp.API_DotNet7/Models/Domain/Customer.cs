using System.ComponentModel.DataAnnotations;

namespace ReactFoodApp.API_DotNet7.Models.Domain;

public class Customer
{
    [Key] // Ensure this is present to define Id as the primary key
    public Guid Id { get; set; }

    public string Name { get; set; }
    public string Email { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
}