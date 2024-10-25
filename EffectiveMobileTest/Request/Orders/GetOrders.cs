using EffectiveMobileTest.Entity;
using MediatR;

namespace EffectiveMobileTest.Request.Orders
{
    public record GetOrders() : IRequest<IEnumerable<Order>>;
}
