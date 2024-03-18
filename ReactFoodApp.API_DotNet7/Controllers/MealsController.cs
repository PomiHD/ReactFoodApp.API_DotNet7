using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ReactFoodApp.API_DotNet7.Models.Repositories;

namespace ReactFoodApp.API_DotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    public class MealsController : ControllerBase
    {
        private readonly IMealRepository _mealRepository;

        public MealsController(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }

        // get all meals
        //Get: api/Meals
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var mealsDomainModel = await _mealRepository.GetAllAsync();

            return Ok(mealsDomainModel);
        }
    }
}