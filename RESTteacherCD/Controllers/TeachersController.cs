using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RESTteacherCD.Managers;
using RESTteacherCD.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTteacherCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private TeachersManager manager = new TeachersManager();

        // GET: api/<TeachersController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return manager.GetAll();
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            return manager.GetById(id);
        }

        // POST api/<TeachersController>
        [HttpPost]
        public Teacher Post([FromBody] Teacher value)
        {
            return manager.Add(value);
        }

        // PUT api/<TeachersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeachersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
