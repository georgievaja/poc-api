using ErrorHandling.Contracts;
using ErrorHandling.Contracts.Types;
using POC.Errors.Functors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorHandling.Api.Errors
{
    internal class ActionErrorResultFactory : IErrorResultFactory
    {
        private readonly IErrorResultHandler _errorResultHandler;
        public ActionErrorResultFactory(IErrorResultHandler errorResultHandler)
        {
            _errorResultHandler = errorResultHandler;
        }

        public Option<TResult> CreateBadDataError<TResult>(IBadDataError badDataError)
        {
            return Option<TResult>.Left(_errorResultHandler.MapResult(badDataError));
        }

        public Option<TResult> CreateNotFoundError<TResult>(INotFoundError notFoundError)
        {
            return Option<TResult>.Left(_errorResultHandler.MapResult(notFoundError));
        }
    }
}