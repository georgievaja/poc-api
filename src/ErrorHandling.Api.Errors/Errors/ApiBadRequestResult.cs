using ErrorHandling.Contracts.Types;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Api.Errors.Errors
{
    internal class ApiBadRequestResult : BadRequestResult, IErrorType
    {

    }
}
