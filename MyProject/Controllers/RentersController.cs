using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using VacationApartments.Entities;
using VacationApartments.Servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VacationApartments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentersController : ControllerBase
    {
        readonly RentersServies r;
        public RentersController()
        {
            r= new RentersServies();    
        }
       
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Renters> Get()
        {
            return r.GetRent();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return $"{r.GetById(id)}";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Renters value)
        {
            r.AddRenter(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id,Renters rent)
        {
            r.UpdateRenter( id,rent);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(Renters renters)
        {
            r.DeleteRenter(renters);
        }


    }
}

