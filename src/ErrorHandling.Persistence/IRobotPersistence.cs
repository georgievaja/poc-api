using POC.Errors.Functors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling.Persistence
{
    public interface IRobotPersistence
    {
        IOption<RoboDto> TryGetRobot(string robotName);
    }
}
