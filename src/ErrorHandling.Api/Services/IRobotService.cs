using POC.Errors.Functors;


namespace POC.Errors.Services
{
    public interface IRobotService
    {
        Option<int> TryGetRobotCounts(string robotName);
    }
}
