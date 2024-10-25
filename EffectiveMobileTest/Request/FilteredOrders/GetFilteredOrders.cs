using MediatR;

namespace EffectiveMobileTest.Request.FilteredOrders
{
    public record GetFilteredOrders(Guid Id) : IRequest<Entity.FilteredOrders>;
}
