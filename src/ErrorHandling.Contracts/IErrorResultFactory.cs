using ErrorHandling.Contracts.Types;
using POC.Errors.Functors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling.Contracts
{
    public interface IErrorResultFactory
    {
        Option<TResult> CreateBadDataError<TResult>(IBadDataError badDataError);
        Option<TResult> CreateNotFoundError<TResult>(INotFoundError notFoundError);
    }
}
