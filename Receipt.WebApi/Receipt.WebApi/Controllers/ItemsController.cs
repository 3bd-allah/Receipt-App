using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Receipt.WebApi.Data;
using Receipt.WebApi.Entities;

namespace Receipt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        //private readonly AppDbContext _context;

        //public ItemsController(AppDbContext context)
        //{
        //    _context = context;
        //}

        [HttpGet]
        
        public List<Item> Method()
        {
            var items = new List<Item>();
            using (var context = new AppDbContext())
            {
                items = context.Items.ToList();
            }
            return items;
        }

    }
}
