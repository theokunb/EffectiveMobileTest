using EffectiveMobileTest.Entity;
using EffectiveMobileTest.Repository;
using MediatR;

namespace EffectiveMobileTest.Request.Orders
{
    public class GetOrdersHandler : IRequestHandler<GetOrders, IEnumerable<Order>>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrdersHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Order>> Handle(GetOrders request, CancellationToken cancellationToken)
        {
            return await _orderRepository.GetAllAsync(cancellationToken);
        }
    }
}
