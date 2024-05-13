using ItemsDetails.Models;
using ItemsDetails.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItemsDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsServices itemsServices;

        public ItemsController(IItemsServices itemsServices)
        {
            this.itemsServices = itemsServices;
        }
        // GET: api/<ItemsController>
        [HttpGet]
        public ActionResult<List<Items>> Get()
        {
            return itemsServices.Get();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var items=itemsServices.GetById(id);
            if(items == null)
            {
                return NotFound($"Items with Id={id} not found");
            }
            return Ok(items);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public ActionResult Post([FromBody] Items items)
        {
            itemsServices.Create(items);
            return CreatedAtAction(nameof(Get),new {id=items.Id},items);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Items items)
        {
            var existingItem= itemsServices.GetById(id);
            if(existingItem == null)
            {
                return NotFound($"Items Id {id} was not found");
            }
            itemsServices.Update(id, items);
            return Ok(items);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var existingItem = itemsServices.GetById(id);
            if (existingItem == null)
            {
                return NotFound($"Items Id {id} was not found");
            }
            itemsServices.Delete(id);
            return Ok($"Item has been deleted successfully");
        }
    }
}
