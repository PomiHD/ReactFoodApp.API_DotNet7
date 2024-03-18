using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactFoodApp.API_DotNet7.Data;

namespace ReactFoodApp.API_DotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    public class MealController : ControllerBase
    {
        private readonly FoodAppDbContext _foodAppDbContext;

        public MealController(FoodAppDbContext foodAppDbContext)
        {
            _foodAppDbContext = foodAppDbContext;
        }

        // get all meals
        //Get: api/Meals
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var mealsDomainModel = await _foodAppDbContext.Meals.ToListAsync();

            return Ok(mealsDomainModel);
        }
    }
}
