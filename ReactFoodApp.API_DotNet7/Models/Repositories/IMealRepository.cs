using ReactFoodApp.API_DotNet7.Models.Domain;

namespace ReactFoodApp.API_DotNet7.Models.Repositories;

public interface IMealRepository
{
    Task<List<Meal>> GetAllAsync();
}