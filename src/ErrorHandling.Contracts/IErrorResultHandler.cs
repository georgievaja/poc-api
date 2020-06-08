using ErrorHandling.Contracts.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling.Contracts
{
    public interface IErrorResultHandler
    {
        IErrorType MapResult(IBadDataError error);
        IErrorType MapResult(INotFoundError error);
    }
}
