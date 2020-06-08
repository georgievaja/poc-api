using POC.Errors.Functors;


namespace POC.Errors.Services
{
    public interface IRobotService
    {
        IOption<int> TryGetRobotCounts(string robotName);
    }
}
