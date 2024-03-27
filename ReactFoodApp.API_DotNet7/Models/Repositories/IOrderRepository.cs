using ReactFoodApp.API_DotNet7.Models.Domain;

namespace ReactFoodApp.API_DotNet7.Models.Repositories;

public interface IOrderRepository
{
    Task<Order> CreateOrderAsync(Order order);
    // Other method definitions
}