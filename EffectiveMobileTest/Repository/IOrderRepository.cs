using EffectiveMobileTest.Entity;

namespace EffectiveMobileTest.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Order>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Order> CreateAsync(Order order, CancellationToken cancellationToken = default);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IQueryable<Order>> FilterBy(Guid cityDistrictId, DateTime from, DateTime to, CancellationToken cancellationToken = default);
    }
}
