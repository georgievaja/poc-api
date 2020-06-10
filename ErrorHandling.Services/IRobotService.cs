using ErrorHandling.Services;
using POC.Errors.Functors;


namespace POC.Errors.Services
{
    public interface IRobotService
    {
        IOption<Robo> TryGetRobot(string robotName);
    }
}
