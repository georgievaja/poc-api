using ErrorHandling.Contracts;
using ErrorHandling.Contracts.Types;
using POC.Errors.Functors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling.Persistence
{
    public class RobotPersistence : IRobotPersistence
    {
        private readonly IErrorResultHandler _errorResultHandler;

        public RobotPersistence(
            IErrorResultHandler errorResultHandler)
        {
            _errorResultHandler = errorResultHandler;
        }

        public IOption<RoboDto> TryGetRobot(string robotName)
        {
            return _errorResultHandler.MapResult<RoboDto>(new NotFoundError("How is your mom", true));
        }
    }
}
