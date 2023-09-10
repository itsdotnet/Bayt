using Bayt.DataAccess.Contracts;
using Bayt.DataAccess.Repositories;

namespace Bayt.Api.Extensions;

public static class CustomService
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}