using ErrorHandling.Contracts.Types;
using System;

namespace POC.Errors.Functors
{
    public class Option<TResult>
    {
        public TResult RightItem { get; }
        public IErrorType LeftItem { get; }
        public bool IsRight { get;  }
        
        public static Option<TResult> Right(TResult value) => new Option<TResult>(value);

        public static Option<TResult> Left(IErrorType value)
        {
            return new Option<TResult>(value);
        }

        private Option(IErrorType err)
        {
            this.IsRight = false;
            this.LeftItem = err;
        }

        private Option(TResult item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            this.RightItem = item;
            this.IsRight = true;
        }
    }
}
