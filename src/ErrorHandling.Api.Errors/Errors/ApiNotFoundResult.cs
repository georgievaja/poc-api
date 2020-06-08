using ErrorHandling.Contracts.Types;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorHandling.Api.Errors.Errors
{
    internal class ApiNotFoundResult : NotFoundResult, IErrorType
    {

    }
}
