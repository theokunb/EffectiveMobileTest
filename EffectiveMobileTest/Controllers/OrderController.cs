using EffectiveMobileTest.Entity;
using EffectiveMobileTest.Request.Orders;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EffectiveMobileTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<Order> GetAsync(Guid id)
        {
            return await _mediator.Send(new GetOrder(id));
        }

        [HttpGet("GetOrders")]
        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _mediator.Send(new GetOrders());
        }

        [HttpPost("CreateOrder")]
        public async Task<Order> CreateOrderAsync([FromBody] CreateOrder createOrder)
        {
            return await _mediator.Send(createOrder);
        }

        [HttpDelete("{id}")]
        public async Task DeleteOrderAsync(Guid id)
        {
            await _mediator.Send(new DeleteOrder(id));
        }
    }
}
