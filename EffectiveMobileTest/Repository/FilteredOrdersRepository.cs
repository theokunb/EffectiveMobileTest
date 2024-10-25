using EffectiveMobileTest.Entity;
using Microsoft.EntityFrameworkCore;

namespace EffectiveMobileTest.Repository
{
    public class FilteredOrdersRepository : IFilteredOrdersRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FilteredOrdersRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FilteredOrders> CreateAsync(FilteredOrders order, CancellationToken cancellationToken = default)
        {
            await _dbContext.Set<FilteredOrders>().AddAsync(order, cancellationToken);

            return order;
        }

        public async Task<FilteredOrders> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<FilteredOrders>()
                .Include(element => element.FiltersAndOrders)
                .FirstOrDefaultAsync(element => element.Id == id);
        }
    }
}
