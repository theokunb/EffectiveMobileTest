using EffectiveMobileTest.Entity;
using MediatR;

namespace EffectiveMobileTest.Request.Orders
{
    public class CreateOrder : IRequest<Order>
    {
        public float Weight { get; set; }
        public Guid CityDistrictId { get; set; }
        public DateTime DeliveryDateTime { get; set; }
    }
}
