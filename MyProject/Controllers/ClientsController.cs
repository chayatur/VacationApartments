using Microsoft.AspNetCore.Mvc;
using VacationApartments.Entities;
using VacationApartments.Servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VacationApartments.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    { 
        readonly ClientsServies cl;
        public ClientsController()
        {
            cl = new ClientsServies();
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return cl.GetClients();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return $"{cl.GetById(id)}";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Client value)
        {
            cl.AddClient(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(Client client)
        {
            cl.UpdateClient(client);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(Client client)
        {
            cl.DeleteClient(client);
        }
       
       
    }
}
