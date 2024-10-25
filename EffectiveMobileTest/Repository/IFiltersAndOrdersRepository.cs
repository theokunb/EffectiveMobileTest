using EffectiveMobileTest.Entity;

namespace EffectiveMobileTest.Repository
{
    public interface IFiltersAndOrdersRepository : IRepository<FiltersAndOrders>
    {
        Task<IEnumerable<FiltersAndOrders>> GetByFilteredOrderIdAsync(Guid filteredOrderId, CancellationToken cancellationToken = default);
        Task<FiltersAndOrders> CreateAsync(FiltersAndOrders filtersAndOrders, CancellationToken cancellationToken = default);
    }
}
