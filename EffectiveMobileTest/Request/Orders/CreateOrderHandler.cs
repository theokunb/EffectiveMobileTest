using AutoMapper;
using EffectiveMobileTest.Entity;
using EffectiveMobileTest.Repository;
using MediatR;
using Newtonsoft.Json;

namespace EffectiveMobileTest.Request.Orders
{
    public class CreateOrderHandler : IRequestHandler<CreateOrder, Order>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateOrderHandler> _logger;

        public CreateOrderHandler(IOrderRepository orderRepository,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ILogger<CreateOrderHandler> logger)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Order> Handle(CreateOrder request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request);

            await _orderRepository.CreateAsync(order, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            _logger.LogInformation("CREATED_ORDER {Order}", JsonConvert.SerializeObject(order));

            return order;
        }
    }
}
