using Microsoft.EntityFrameworkCore;
using ReactFoodApp.API_DotNet7.Data;
using ReactFoodApp.API_DotNet7.Models.Domain;

namespace ReactFoodApp.API_DotNet7.Models.Repositories;

public class SqlMealRepository : IMealRepository
{
    private readonly FoodAppDbContext _foodAppDbContext;

    public SqlMealRepository(FoodAppDbContext foodAppDbContext)
    {
        _foodAppDbContext = foodAppDbContext;

    }

    public async Task<List<Meal>> GetAllAsync()
    {
        return await _foodAppDbContext.Meals.ToListAsync();
    }
}