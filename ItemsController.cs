
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/Items")]
    public class ItemsController : Controller
    {

        private ItemsDbContext items;

        public ItemsController(ItemsDbContext _items)
        {
            items = _items;
        }

        // GET: api/Items
        [HttpGet]
        public IEnumerable<Items> Get()
        {
            return items.items;
        }

        // GET: api/Items/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Items
        [HttpPost]
        public IActionResult Post([FromBody]Items item)
        {
            items.items.Add(item);
            items.SaveChanges(true);
            return StatusCode(StatusCodes.Status201Created);

        }
        
        // PUT: api/Items/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

