using AutoMapper;
using EffectiveMobileTest.Entity;
using EffectiveMobileTest.Request.Orders;

namespace EffectiveMobileTest.AutoMapper
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<CreateOrder, Order>().ForMember(des => des.Weight, conf => conf.MapFrom(source => source.Weight))
                .ForMember(des => des.DeliveryDateTime, conf => conf.MapFrom(source => source.DeliveryDateTime))
                .ForMember(des => des.CityDistrictId, conf => conf.MapFrom(source => source.CityDistrictId));
        }
    }
}
