using MediatR;

namespace EffectiveMobileTest.Request.Orders
{
    public record DeleteOrder(Guid Id) : IRequest;
}
