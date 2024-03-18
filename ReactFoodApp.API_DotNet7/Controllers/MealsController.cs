using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ReactFoodApp.API_DotNet7.Models.Dtos;
using ReactFoodApp.API_DotNet7.Models.Repositories;

namespace ReactFoodApp.API_DotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    public class MealsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMealRepository _mealRepository;

        public MealsController(IMealRepository mealRepository, IMapper mapper)
        {
            _mealRepository = mealRepository;
            _mapper = mapper;
        }

        // get all meals
        //Get: api/Meals
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var mealsDomainModel = await _mealRepository.GetAllAsync();
            // map domain model to DTO
            var mealsDto = _mapper.Map<List<MealDto>>(mealsDomainModel);

            return Ok(mealsDto);
        }
    }
}
