using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Receipt.WebApi.Data;
using Receipt.WebApi.Entities;

namespace Receipt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        
        [HttpPost]
        public void PostOrder([Bind(nameof(OrderItems.ItemId))]List<OrderItems>orderItems)
        {
            var context = new AppDbContext();
           
            // list of order items ids
            // select * items where itemId in (orderItemsIds)
            // create order 

            var newOrder = new Order();
            foreach (var orderItem in orderItems) {
                var item = context.Items.Where(x => x.Id == orderItem.ItemId).FirstOrDefault();

                // check each quantity with instock
                // throw exception when the stock of item was run out 
                if (item is not null && item.InStock >= orderItem.Quantity)
                {

                    // update items.stock - quantity
                    item.InStock -= orderItem.Quantity;
                    orderItem.item = item;
                    orderItem.Order = newOrder;
                    newOrder.orderItems.Add(orderItem);
                    newOrder.Items.Add(item);
                }
                else
                {
                    throw new Exception("The quantity exceeded the amount in stock");
                }
            }
            context.Orders.Add(newOrder);
            context.SaveChanges();
            
            
        }

       
    }
}
