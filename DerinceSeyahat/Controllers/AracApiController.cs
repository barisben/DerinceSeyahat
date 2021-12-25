using DerinceSeyahat.DA;
using DerinceSeyahat.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DerinceSeyahat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AracApiController : ControllerBase
    {
        private readonly IAracRepo arac;

        public AracApiController(IAracRepo a)
        {
            this.arac = a;
        }

        // GET: api/<AracApiController>
        [HttpGet]
        public List<Arac> Get()
        {
            return arac.GetAracs();
        }

        // GET api/<AracApiController>/5
        [HttpGet("{id}")]
        public Arac Get(int id)
        {
            return arac.GetAracById(id);
        }

        // POST api/<AracApiController>
        [HttpPost]
        public Arac Post([FromBody] Arac value)
        {
            return arac.CreateArac(value);
        }

        // PUT api/<AracApiController>/5
        [HttpPut("{id}")]
        public Arac Put(int id, [FromBody] Arac value)
        {
            return arac.UpdateArac(id, value);
        }

        // DELETE api/<AracApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            arac.DeleteArac(id);
        }
    }
}
