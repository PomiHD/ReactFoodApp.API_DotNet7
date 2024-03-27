using ReactFoodApp.API_DotNet7.Data;
using ReactFoodApp.API_DotNet7.Models.Domain;

namespace ReactFoodApp.API_DotNet7.Models.Repositories;

public class SqlOrderRepository : IOrderRepository
{
    private readonly FoodAppDbContext _context;

    public SqlOrderRepository(FoodAppDbContext context)
    {
        _context = context;
    }

    public async Task<Order> CreateOrderAsync(Order order)
    {
        // Assuming Order includes navigation properties for Items and Customer
        // that should be handled by EF Core's change tracking
        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();
        return order; // EF Core populates the ID after SaveChangesAsync
    }

    // Implement additional repository methods as needed
}
