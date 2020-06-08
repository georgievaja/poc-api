using ErrorHandling.Contracts;
using ErrorHandling.Contracts.Types;
using POC.Errors.Functors;

namespace POC.Errors.Services
{
    public class RobotService : IRobotService
    {
        private readonly IErrorResultFactory _errorResultFactory;

        public RobotService(IErrorResultFactory errorResultFactory)
        {
            _errorResultFactory = errorResultFactory;
        }

        public Option<int> TryGetRobotCounts(string robotName)
        {
            if (string.IsNullOrWhiteSpace(robotName))
            {
                return _errorResultFactory.CreateBadDataError<int>(new BadDataError("Dark side of your mom", 1));
            }

            return _errorResultFactory.CreateNotFoundError<int>(new NotFoundError("How is your mom", true));
        }
    }
}
