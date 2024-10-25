using EffectiveMobileTest.Entity;
using EffectiveMobileTest.Repository;
using MediatR;

namespace EffectiveMobileTest.Request.Orders
{
    public class GetOrderHandler : IRequestHandler<GetOrder, Order>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> Handle(GetOrder request, CancellationToken cancellationToken)
        {
            return await _orderRepository.GetAsync(request.Id, cancellationToken);
        }
    }
}
