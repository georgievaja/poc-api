using ErrorHandling.Contracts.Types;
using System;
using System.Diagnostics.CodeAnalysis;

namespace POC.Errors.Functors
{
    public interface IOption<TResult>
    {
        public TResult RightItem { get; }
        public bool IsRight { get;  }
        IOption<T> Select<T>([DisallowNull] Func<TResult, T> selector);
    }
}
