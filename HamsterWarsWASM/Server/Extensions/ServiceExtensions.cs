using DataAccess.EFCore.Services.GenericService;
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
        services.AddScoped<DataContext>();
        //-----------|  Repositories
        //-----------|  Services
        services.AddTransient(typeof(IGenericService<>), typeof(GenericService<>));
        services.AddTransient<IHamsterService, HamsterService>();
        services.AddTransient<IMatchService, MatchService>();
    }
}
