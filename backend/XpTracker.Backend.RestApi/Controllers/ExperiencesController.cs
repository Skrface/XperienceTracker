using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace XpTracker.Backend.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        // GET api/experiences
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "experience1", "experience2" };
        }

        // GET api/experiences/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "experience";
        }

        // POST api/experiences
        [HttpPost]
        public void Post([FromBody] string experience)
        {
            try
            {
                if (experience.IsObjectNull())
                {
                    return BadRequest("Owner object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                _repository.Owner.CreateOwner(owner);

                return CreatedAtRoute("OwnerById", new { id = owner.Id }, owner);
            }
            catch(Exception e)
            {
                _logger.LogError($"Something went wrong inside the CreateOwner action: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT api/experiences/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string experience)
        {
        }

        // DELETE api/experiences/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
