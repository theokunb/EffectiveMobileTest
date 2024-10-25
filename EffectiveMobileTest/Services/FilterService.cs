using EffectiveMobileTest.Entity;
using EffectiveMobileTest.Options;
using EffectiveMobileTest.Repository;
using Microsoft.Extensions.Options;

namespace EffectiveMobileTest.Services
{
    public class FilterService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IFilteredOrdersRepository _filteredOrdersRepository;
        private readonly IFiltersAndOrdersRepository _filtersAndOrdersRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly DeliverySetting _deliverySetting;
        private readonly ILogger<FilterService> _logger;

        public FilterService(IOrderRepository orderRepository, 
            IFilteredOrdersRepository filteredOrdersRepository,
            IFiltersAndOrdersRepository filtersAndOrdersRepository,
            IUnitOfWork unitOfWork,
            IOptions<DeliverySetting> deliverySettingOptions,
            ILogger<FilterService> logger)
        {
            _orderRepository = orderRepository;
            _filteredOrdersRepository = filteredOrdersRepository;
            _filtersAndOrdersRepository = filtersAndOrdersRepository;
            _unitOfWork = unitOfWork;
            _deliverySetting = deliverySettingOptions.Value;
            _logger = logger;
        }

        public async Task<Guid> FilterByParamsAsync(Guid cityDistrict,
            DateTime firstDeliveryDateTime, CancellationToken
            cancellationToken = default)
        {
            var orders = (await _orderRepository.FilterBy(cityDistrict,
            firstDeliveryDateTime,
            firstDeliveryDateTime.AddMinutes(_deliverySetting.TimeSpread)))
                          .ToList();

            var filteredOreder = new Entity.FilteredOrders();
            await _filteredOrdersRepository.CreateAsync(filteredOreder, cancellationToken);

            foreach (var order in orders)
            {
                var filterAndOrder = new FiltersAndOrders()
                {
                    OrderId = order.Id,
                    FilteredOrdersId = filteredOreder.Id
                };

                await _filtersAndOrdersRepository.CreateAsync(filterAndOrder, cancellationToken);
            }

            await _unitOfWork.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("CREATED_FILTERED_ORDER {Id}", filteredOreder.Id);

            return filteredOreder.Id;
        }
    }
}
