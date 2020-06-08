using ErrorHandling.Api.Errors.Errors;
using ErrorHandling.Api.Errors.Functors;
using ErrorHandling.Contracts;
using ErrorHandling.Contracts.Types;
using POC.Errors.Functors;

namespace ErrorHandling.Api.Errors
{
    internal class ActionErrorResultHandler : IErrorResultHandler
    {
        public IOption<TResult> MapResult<TResult>(INotFoundError error)
        {
            return ApiOption<TResult>.Left(new ApiNotFoundResult());
        }

        public IOption<TResult> MapResult<TResult>(IBadDataError error)
        {
            return ApiOption<TResult>.Left(new ApiBadRequestResult());
        }
    }
}
