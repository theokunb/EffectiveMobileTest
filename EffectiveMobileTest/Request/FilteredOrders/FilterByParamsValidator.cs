using FluentValidation;

namespace EffectiveMobileTest.Request.FilteredOrders
{
    public class FilterByParamsValidator : AbstractValidator<FilterByParamsRequest>
    {
        public FilterByParamsValidator()
        {
            RuleFor(x=> x.FirstDeliveryDateTime).NotEmpty();
            RuleFor(x=> x.CityDistrict).NotEmpty();
        }
    }
}
