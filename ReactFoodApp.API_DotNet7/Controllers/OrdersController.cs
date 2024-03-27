using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ReactFoodApp.API_DotNet7.Models.Domain;
using ReactFoodApp.API_DotNet7.Models.Dtos;
using ReactFoodApp.API_DotNet7.Models.Repositories;

namespace ReactFoodApp.API_DotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrdersController(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto orderDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var order = _mapper.Map<Order>(orderDto);
            var createdOrder = await _orderRepository.CreateOrderAsync(order);

            return CreatedAtAction(nameof(CreateOrder), new { id = createdOrder.Id }, createdOrder);
        }
    }
}