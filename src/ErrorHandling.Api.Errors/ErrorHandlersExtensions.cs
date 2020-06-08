using ErrorHandling.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;

namespace ErrorHandling.Api.Errors
{
    public static class ErrorHandlersExtensions
    {
        [return: NotNull]
        public static IServiceCollection UseActionResultErrorHandling(
            [DisallowNull] this IServiceCollection services)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddTransient<IErrorResultHandler, ActionErrorResultHandler>();

            return services;
        }
    }
}
