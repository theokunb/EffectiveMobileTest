using EffectiveMobileTest.Services;
using FluentValidation;
using MediatR;

namespace EffectiveMobileTest.Request.FilteredOrders
{
    public class FilterByParamsHandler : IRequestHandler<FilterByParamsRequest, Guid>
    {
        private readonly FilterService _filterService;
        private readonly FilterByParamsValidator _filterByParamsValidator;

        public FilterByParamsHandler(FilterService filterService, FilterByParamsValidator filterByParamsValidator)
        {
            _filterService = filterService;
            _filterByParamsValidator = filterByParamsValidator;
        }

        public async Task<Guid> Handle(FilterByParamsRequest request, CancellationToken cancellationToken)
        {
            var validateResult = _filterByParamsValidator.Validate(request);

            if (!validateResult.IsValid)
            {
                throw new ValidationException(validateResult.Errors);
            }

            return await _filterService.FilterByParamsAsync(request.CityDistrict.Value, request.FirstDeliveryDateTime.Value, cancellationToken);
        }
    }
}
