using Microsoft.AspNetCore.Mvc;
using POC.Errors.Services;

namespace POC.Errors.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoboController : ControllerBase
    {
        private readonly IRobotService _robotService;
        public RoboController(
            IRobotService robotService)
        {
            _robotService = robotService;
        }

        [HttpGet]
        public IActionResult Get(string roboName)
        {
            var result = _robotService.TryGetRobotCounts(roboName);

            if (result.IsRight)
            {
                return Ok(result);
            }

            //TODO: I do not especially like this blind conversion..
            return result.LeftItem as ActionResult;
        }
    }
}
