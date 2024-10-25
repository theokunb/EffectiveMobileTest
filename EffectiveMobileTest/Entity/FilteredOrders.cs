namespace EffectiveMobileTest.Entity
{
    public class FilteredOrders : BaseEntity
    {
        public IEnumerable<FiltersAndOrders>? FiltersAndOrders { get; set; }
    }
}
