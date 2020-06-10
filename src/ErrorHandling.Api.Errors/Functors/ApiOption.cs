using Microsoft.AspNetCore.Mvc;
using POC.Errors.Functors;
using System;
using System.Diagnostics.CodeAnalysis;

namespace ErrorHandling.Api.Errors.Functors
{
    public class ApiOption<TResult>: IOption<TResult>
    {
        public TResult RightItem { get; }
        public IActionResult LeftItem { get; }
        public bool IsRight { get; }

        public static ApiOption<TResult> Right(TResult value) => new ApiOption<TResult>(value);

        public static ApiOption<TResult> Left(IActionResult value)
        {
            return new ApiOption<TResult>(value);
        }

        private ApiOption(IActionResult err)
        {
            this.IsRight = false;
            this.LeftItem = err;
        }

        private ApiOption(TResult item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            this.RightItem = item;
            this.IsRight = true;
        }

        [return: NotNull]
        public IActionResult SelectResult(
            [DisallowNull] Func<TResult, IActionResult> onRight)
        {
            if (onRight == null) throw new ArgumentNullException(nameof(onRight));

            return this.IsRight ? onRight(RightItem) : LeftItem;
        }

        public IOption<T> Select<T>([DisallowNull] Func<TResult, T> selector)
        {
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            return this.IsRight  ? new ApiOption<T>(selector(this.RightItem)) : new ApiOption<T>(LeftItem);
        }
    }
}
