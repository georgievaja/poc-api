using ErrorHandling.Api.Errors.Functors;
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
            return _robotService
                .TryGetRobot(roboName)
                .ToApiOption()
                .SelectResult(right => Ok(right));
        }
    }
}
