using FluentValidation;

namespace EffectiveMobileTest.Request.Orders
{
    public class CreateOrderValidator : AbstractValidator<CreateOrder>
    {
        public CreateOrderValidator()
        {
            RuleFor(createOrder => createOrder.Weight).GreaterThan(0);
            RuleFor(createOrder => createOrder.DeliveryDateTime).GreaterThan(DateTime.UtcNow);
        }
    }
}
