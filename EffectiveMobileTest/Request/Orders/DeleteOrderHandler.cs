using EffectiveMobileTest.Repository;
using MediatR;

namespace EffectiveMobileTest.Request.Orders
{
    public class DeleteOrderHandler : IRequestHandler<DeleteOrder>
    {
        private readonly IOrderRepository _orederRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeleteOrderHandler> _logger;

        public DeleteOrderHandler(IOrderRepository orederRepository, IUnitOfWork unitOfWork, ILogger<DeleteOrderHandler> logger)
        {
            _orederRepository = orederRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task Handle(DeleteOrder request, CancellationToken cancellationToken)
        {
            await _orederRepository.DeleteAsync(request.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            _logger.LogInformation("DELETED_ORDER {Id}", request.Id);
        }
    }
}
