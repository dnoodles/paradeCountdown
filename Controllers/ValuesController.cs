using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SantaTracker.Models;
using SantaTracker.Contexts;
using Microsoft.EntityFrameworkCore;

namespace SantaTracker.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ParadeContext _context;
        public ValuesController(ParadeContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public OkObjectResult Get()
        {
            Console.WriteLine(_context.Coordinates.OrderByDescending(p => p.ID).FirstOrDefault());
            return Ok(_context.Coordinates.OrderByDescending(p => p.ID).FirstOrDefault());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public OkResult Post([FromBody] Coordinates coordinates)
        {
            Console.WriteLine(coordinates.lat);
            _context.Coordinates.Add(coordinates);
            _context.SaveChanges();
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
