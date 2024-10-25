using MediatR;

namespace EffectiveMobileTest.Request.FilteredOrders
{
    public class FilterByParamsRequest : IRequest<Guid>
    {
        public FilterByParamsRequest()
        {
        }

        public FilterByParamsRequest(Guid? cityDistrict, DateTime? firstDeliveryDateTime)
        {
            CityDistrict = cityDistrict;
            FirstDeliveryDateTime = firstDeliveryDateTime;
        }

        public Guid? CityDistrict { get; set; }
        public DateTime? FirstDeliveryDateTime { get; set; }
    }
}
