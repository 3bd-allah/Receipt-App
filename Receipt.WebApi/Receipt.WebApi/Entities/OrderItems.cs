namespace Receipt.WebApi.Entities
{
    public class OrderItems
    {
        public int OrderId { get; set; }
        public Order Order { get; set; } = new Order();

        public int ItemId { get; set; }
        public Item item { get; set; } = new Item();
        public int Quantity { get; set; }
    }
}
