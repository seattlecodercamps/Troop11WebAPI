using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MegaTron.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MegaTron.API
{
    [Route("api/[controller]")]
    public class CheeseController : Controller
    {

        static List<Cheese> _cheeseList = new List<Cheese>()
        {
            new Cheese {Id=1, Name="Cheddar", Smelliness=0, Spreadable=false },
            new Cheese {Id=2, Name="Brie", Smelliness=3, Spreadable=true },
            new Cheese {Id=3, Name="American", Smelliness=0, Spreadable=false }
        };

        static int counter = 1000;

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cheeseList);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var match = _cheeseList.Find(c => c.Id == id);
            if (match == null)
            {
                return NotFound();
            }
            return Ok(match);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Cheese cheese)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }
            counter++;
            cheese.Id = counter;
            _cheeseList.Add(cheese);
            return Ok(cheese);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var match = _cheeseList.Find(c => c.Id == id);
            if (match == null)
            {
                return NotFound();
            }
            _cheeseList.Remove(match);
            return Ok();
        }
    }
}
