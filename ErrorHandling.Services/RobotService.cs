using ErrorHandling.Contracts;
using ErrorHandling.Contracts.Types;
using ErrorHandling.Persistence;
using ErrorHandling.Services;
using POC.Errors.Functors;

namespace POC.Errors.Services
{
    public class RobotService : IRobotService
    {
        private readonly IErrorResultHandler _errorResultHandler;
        private readonly IRobotPersistence _robotPersistence;

        public RobotService(
            IErrorResultHandler errorResultHandler,
            IRobotPersistence robotPersistence)
        {
            _errorResultHandler = errorResultHandler;
            _robotPersistence = robotPersistence;
        }

        public IOption<Robo> TryGetRobot(string robotName)
        {
            if (string.IsNullOrWhiteSpace(robotName))
            {
                return _errorResultHandler.MapResult<Robo>(new BadDataError("Dark side of your mom", 1));
            }

            var result = _robotPersistence.TryGetRobot(robotName);
            
            return result.Select(right => new Robo()
            {
                Name = right.Name
            });
        }
    }
}
