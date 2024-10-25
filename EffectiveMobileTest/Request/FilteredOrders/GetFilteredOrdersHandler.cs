using EffectiveMobileTest.Repository;
using MediatR;

namespace EffectiveMobileTest.Request.FilteredOrders
{
    public class GetFilteredOrdersHandler : IRequestHandler<GetFilteredOrders, Entity.FilteredOrders>
    {
        private readonly IFilteredOrdersRepository _filteredOrdersRepository;
        private readonly IFiltersAndOrdersRepository _filtersAndOrdersRepository;

        public GetFilteredOrdersHandler(IFilteredOrdersRepository filteredOrders, IFiltersAndOrdersRepository filtersAndOrdersRepository)
        {
            _filteredOrdersRepository = filteredOrders;
            _filtersAndOrdersRepository = filtersAndOrdersRepository;
        }

        public async Task<Entity.FilteredOrders> Handle(GetFilteredOrders request, CancellationToken cancellationToken)
        {
            await _filtersAndOrdersRepository.GetByFilteredOrderIdAsync(request.Id, cancellationToken);
            var filteredOrder =  await _filteredOrdersRepository.GetAsync(request.Id, cancellationToken);

            return filteredOrder;
        }
    }
}
