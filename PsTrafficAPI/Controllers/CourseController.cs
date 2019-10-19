using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PsTrafficAPI.Model;
using PsTrafficAPI.Services;

namespace PsTrafficAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Course>> Get()
        {
            return new CourseData().GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(200), ProducesResponseType(404)]
        public ActionResult<Course> GetById(int id)
        {
            Course course= new CourseData().GetById(id);
            if(course==null)
            {
                return NotFound();
            }
            return course;
        }

        [HttpGet]
        [Route("environment")]
        public ActionResult<string> GetEnvironment()
        {
            return Environment.GetEnvironmentVariable("REGION_NAME") ?? "LOCAL";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
