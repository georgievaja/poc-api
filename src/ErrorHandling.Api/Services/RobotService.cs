using ErrorHandling.Contracts;
using ErrorHandling.Contracts.Types;
using POC.Errors.Functors;

namespace POC.Errors.Services
{
    public class RobotService : IRobotService
    {
        private readonly IErrorResultHandler _errorResultHandler;

        public RobotService(IErrorResultHandler errorResultHandler)
        {
            _errorResultHandler = errorResultHandler;
        }

        public IOption<int> TryGetRobotCounts(string robotName)
        {
            if (string.IsNullOrWhiteSpace(robotName))
            {
                return _errorResultHandler.MapResult<int>(new BadDataError("Dark side of your mom", 1));
            }

            return _errorResultHandler.MapResult<int>(new NotFoundError("How is your mom", true));
        }
    }
}
