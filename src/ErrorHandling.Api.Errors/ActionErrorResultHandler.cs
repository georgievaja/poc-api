using ErrorHandling.Api.Errors.Errors;
using ErrorHandling.Contracts;
using ErrorHandling.Contracts.Types;

namespace ErrorHandling.Api.Errors
{
    internal class ActionErrorResultHandler : IErrorResultHandler
    {
        public IErrorType MapResult(INotFoundError error)
        {
            return new ApiNotFoundResult();
        }

        public IErrorType MapResult(IBadDataError error)
        {
            return new ApiBadRequestResult();
        }
    }
}
