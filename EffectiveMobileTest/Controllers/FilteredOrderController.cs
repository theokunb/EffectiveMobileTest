using EffectiveMobileTest.Entity;
using EffectiveMobileTest.Request.FilteredOrders;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EffectiveMobileTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilteredOrderController
    {
        private readonly IMediator _mediator;

        public FilteredOrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<FilteredOrders> GetAsync(Guid id)
        {
            return await _mediator.Send(new GetFilteredOrders(id));
        }

        [HttpGet("FilterByParams")]
        public async Task<Guid> FilterByParamsAsync(Guid? cityDistrict, DateTime? firstDeliveryDateTime)
        {
            return await _mediator.Send(new FilterByParamsRequest(cityDistrict, firstDeliveryDateTime));
        }

        [HttpPost("FilterByFile")]
        public async Task<Guid> FilterByFileAsync(IFormFile file)
        {
            return await _mediator.Send(new FilterByFileRequest(file));
        }
    }
}
