using EffectiveMobileTest.Entity;
using MediatR;

namespace EffectiveMobileTest.Request.Orders
{
    public record GetOrder(Guid Id) : IRequest<Order>;
}
