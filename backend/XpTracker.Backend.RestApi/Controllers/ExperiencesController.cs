using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XpTracker.Backend.Core.Service.Facades;
using XpTracker.Backend.Core.Service.Log;
using XpTracker.Backend.Core.ViewModel.Experience;

namespace XpTracker.Backend.RestApi.Controllers
{
    /// <summary>
    /// Experience endpoint
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ExperiencesController : BaseXpTrackerController
    {
        private readonly IFacadeExperienceService _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="logger"></param>
        public ExperiencesController(IFacadeExperienceService service, IXpTrackerLogger logger) : base(logger)
        {
            this._service = service;
        }

        /// <summary>
        /// Get the list of experiences for the current user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<VmExperienceResponseGet>> Get()
        {
           // this._logger.Debug($"RESTAPI:FeedbacksController:Get()");
            VmExperienceResponseGet result = new VmExperienceResponseGet();
            try
            {
                var data = _service.GetAllForCurrentUser();

                if(data.Any())
                {
                    result.Data = data;
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                //this._logger.Error("FeedbacksController::Get:Exception(e)", e);
                result.Message = e.Message;
                return StatusCode(500, result);
            }

            return result;
        }

        /// <summary>
        /// Get an experience of the current user by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "experience";
        }

        /// <summary>
        /// Add a new experience associated the current user
        /// </summary>
        /// <param name="experience"></param>
        [HttpPost]
        public void Create([FromBody] string experience)
        {
            //try
            //{
            //    if (experience.IsObjectNull())
            //    {
            //        return BadRequest("Owner object is null");
            //    }

            //    if (!ModelState.IsValid)
            //    {
            //        return BadRequest("Invalid model object");
            //    }

            //    _repository.Owner.CreateOwner(owner);

            //    return CreatedAtRoute("OwnerById", new { id = owner.Id }, owner);
            //}
            //catch(Exception e)
            //{
            //    _logger.LogError($"Something went wrong inside the CreateOwner action: {ex}");
            //    return StatusCode(500, "Internal server error");
            //}
        }

        /// <summary>
        /// Update an experience associated the current user
        /// </summary>
        /// <param name="experience"></param>
        [HttpPost]
        public void Edit([FromBody] string experience)
        {
            //try
            //{
            //    if (experience.IsObjectNull())
            //    {
            //        return BadRequest("Owner object is null");
            //    }

            //    if (!ModelState.IsValid)
            //    {
            //        return BadRequest("Invalid model object");
            //    }

            //    _repository.Owner.CreateOwner(owner);

            //    return CreatedAtRoute("OwnerById", new { id = owner.Id }, owner);
            //}
            //catch(Exception e)
            //{
            //    _logger.LogError($"Something went wrong inside the CreateOwner action: {ex}");
            //    return StatusCode(500, "Internal server error");
            //}
        }

        /// <summary>
        /// Delete an experience
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
