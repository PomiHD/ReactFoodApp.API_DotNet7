using AutoMapper;
using ReactFoodApp.API_DotNet7.Models.Domain;
using ReactFoodApp.API_DotNet7.Models.Dtos;

namespace ReactFoodApp.API_DotNet7.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Meal, MealDto>().ReverseMap();
            CreateMap<CreateOrderDto, Order>();
            CreateMap<CreateItemDto, Item>();
            CreateMap<CreateCustomerDto, Customer>();
        }
    }
}