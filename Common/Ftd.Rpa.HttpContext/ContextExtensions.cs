using Microsoft.Extensions.DependencyInjection;

namespace Ftd.Rpa.HttpContext
{
    public static class ContextExtensions
    {
        public static IServiceCollection AddContextServices(this IServiceCollection serviceCollection) =>
            serviceCollection
                .AddHttpContextAccessor()
                .AddScoped<ICurrentResourceGroup, HttpContextWrapper>()
                .AddScoped<ICurrentUser, HttpContextWrapper>()
                .AddScoped<ICurrentTrace, HttpContextWrapper>()
                .AddScoped<ICurrentTenant, HttpContextWrapper>();
    }
}
