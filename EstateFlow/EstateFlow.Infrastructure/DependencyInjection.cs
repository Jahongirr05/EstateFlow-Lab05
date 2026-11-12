using EstateFlow.Application;
using EstateFlow.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EstateFlow.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<EstateFlowDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("EstateFlowDbConnection")));

        services.AddScoped<IApplicationDbContext>(provider =>
            provider.GetRequiredService<EstateFlowDbContext>());

        return services;
    }
}
