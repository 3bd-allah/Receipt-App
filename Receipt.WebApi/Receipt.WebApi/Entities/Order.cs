using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;

namespace Receipt.WebApi.Entities
{
    public class Order
    {

        public int Id { get; set; }
        public DateTime CreatedAt { get;  }
        public ICollection<Item> Items { get; set; } = new List<Item>();
        public ICollection<OrderItems> orderItems { get; set; } = new List<OrderItems>(); 

        public Order()
        {
            this.CreatedAt = DateTime.Now;
        }
    }
}
