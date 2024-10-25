using EffectiveMobileTest.Entity;
using Microsoft.EntityFrameworkCore;

namespace EffectiveMobileTest.Repository
{
    public class FiltersAndOrdersRepository : IFiltersAndOrdersRepository
    {
        private readonly ApplicationDbContext _context;

        public FiltersAndOrdersRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<FiltersAndOrders> CreateAsync(FiltersAndOrders filtersAndOrders, CancellationToken cancellationToken = default)
        {
            await _context.AddAsync(filtersAndOrders);

            return filtersAndOrders;
        }

        public async Task<IEnumerable<FiltersAndOrders>> GetByFilteredOrderIdAsync(Guid filteredOrderId, CancellationToken cancellationToken = default)
        {
            return await _context.Set<FiltersAndOrders>()
                .Where(element => element.FilteredOrdersId == filteredOrderId)
                .Include(element => element.Order)
                .ToListAsync(cancellationToken);
        }
    }
}
