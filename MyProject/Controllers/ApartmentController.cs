using Microsoft.AspNetCore.Mvc;
using VacationApartments.Entities;
using VacationApartments.Servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VacationApartments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        readonly ApartmentsServies s;
        public ApartmentController()
        {
            s = new ApartmentsServies();
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Apartments> Get()
        {
            return s.GetApartment();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return $"{s.GetById(id)}";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Apartments value)
        {
            s.AddApartment(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(Apartments apartment)
        {
             s.UpdateApartment(apartment);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int  id)
        {
            s.DeleteApartment(id);
        }
        // PUT api/<Renters>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] int value)
        {
            s.UpdateLevel(id, value);
        }
    }
}
