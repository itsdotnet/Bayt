using Bayt.DataAccess.Contracts;
using Bayt.DataAccess.Repositories;
using Bayt.Service.Mappers;

namespace Bayt.Api.Extensions;

public static class CustomService
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddAutoMapper(typeof(MappingProfile));
    }
}