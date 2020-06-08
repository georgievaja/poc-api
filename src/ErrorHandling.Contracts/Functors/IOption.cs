using ErrorHandling.Contracts.Types;
using System;

namespace POC.Errors.Functors
{
    public interface IOption<TResult>
    {
        public TResult RightItem { get; }
        public bool IsRight { get;  }
    }
}
