using Microsoft.EntityFrameworkCore;

namespace HamsterWarsWASM.Server.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureSqlContext(this IServiceCollection services,
    IConfiguration configuration) =>
    services.AddDbContext<DataContext>(opts =>
    opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

    public static void ConfigureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        //-----------|  DbContext
        //-----------|  Repositories
        //-----------|  Services
        services.AddScoped<IHamsterService, HamsterService>();
        services.AddScoped<IMatchService, MatchService>();
    }
}
