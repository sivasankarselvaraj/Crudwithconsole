using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationSankar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsSPController : ControllerBase
    {
        private readonly IDoctors Run;
        public DoctorsSPController()
        {
            Run = new DoctorsRepository();
        }
        // GET: api/<DoctorsSPController>
        [HttpGet]
        public List<Doctors> Get()
        {
            return Run.GetAll();
        }

        // GET api/<DoctorsSPController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DoctorsSPController>
        [HttpPost]
        public void Post([FromBody] Doctors value)
        {
            Run.Insert(value);
        }

        // PUT api/<DoctorsSPController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctors value)
        {
            Run.Update(id, value);
        }

        // DELETE api/<DoctorsSPController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Run.Delete(id);
        }
    }
}
