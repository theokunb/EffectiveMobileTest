namespace EffectiveMobileTest.Entity
{
    public class Order : BaseEntity
    {
        public float Weight { get; set; }
        public Guid CityDistrictId { get; set; }
        public DateTime DeliveryDateTime { get; set; }
    }
}
