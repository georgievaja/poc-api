using ErrorHandling.Contracts.Types;
using POC.Errors.Functors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling.Contracts
{
    public interface IErrorResultHandler
    {
        IOption<TResult> MapResult<TResult>(IBadDataError error);
        IOption<TResult> MapResult<TResult>(INotFoundError error);
    }
}
