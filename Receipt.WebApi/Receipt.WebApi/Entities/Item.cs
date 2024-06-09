namespace Receipt.WebApi.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name{ get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public ICollection<OrderItems> orderItems { get; set; }= new List<OrderItems>();
    }
}
