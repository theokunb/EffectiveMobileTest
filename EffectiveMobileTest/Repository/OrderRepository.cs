using EffectiveMobileTest.Entity;
using Microsoft.EntityFrameworkCore;

namespace EffectiveMobileTest.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> CreateAsync(Order order, CancellationToken cancellationToken = default)
        {
            await _dbContext.Set<Order>().AddAsync(order, cancellationToken);
            return order;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var order = await _dbContext.Set<Order>().FirstOrDefaultAsync(element => element.Id == id, cancellationToken);

            if (order == null)
                return;

            _dbContext.Set<Order>().Remove(order);
        }

        public async Task<IEnumerable<Order>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<Order>().ToListAsync(cancellationToken);
        }

        public async Task<Order> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<Order>().FirstOrDefaultAsync(element => element.Id == id, cancellationToken);
        }

        public async Task<IQueryable<Order>> FilterBy(Guid cityDistrictId, DateTime from, DateTime to, CancellationToken cancellationToken = default)
        {
            return _dbContext.Set<Order>()
                .Where(element => element.CityDistrictId == cityDistrictId
                               && element.DeliveryDateTime >= from && element.DeliveryDateTime <= to);
        }
    }
}
