using EffectiveMobileTest.Entity;

namespace EffectiveMobileTest.Repository
{
    public interface IFilteredOrdersRepository : IRepository<FilteredOrders>
    {
        Task<FilteredOrders> GetAsync(Guid id, CancellationToken cancellationToken = default);
        Task<FilteredOrders> CreateAsync(FilteredOrders order, CancellationToken cancellationToken = default);
    }
}
