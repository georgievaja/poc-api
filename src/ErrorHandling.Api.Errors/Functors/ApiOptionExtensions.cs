using POC.Errors.Functors;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ErrorHandling.Api.Errors.Functors
{
    public static class ApiOptionExtensions
    {
        public static ApiOption<TResult> ToApiOption<TResult>(
            [DisallowNull] this IOption<TResult> option)
        {
            if (option is null)
            {
                throw new ArgumentNullException(nameof(option));
            }

            return option as ApiOption<TResult>;
        }
    }
}
