namespace EffectiveMobileTest.Entity
{
    public class FiltersAndOrders : BaseEntity
    {
        public Guid FilteredOrdersId { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
