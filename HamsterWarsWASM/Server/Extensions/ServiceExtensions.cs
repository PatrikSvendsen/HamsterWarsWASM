using DataAccess.EFCore.Services.GenericService;
using Microsoft.EntityFrameworkCore;

namespace HamsterWarsWASM.Server.Extensions;

public static class ServiceExtensions
{
    /// <summary>
    /// Används för att injecera SQL koden samt hämta connectionstring
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public static void ConfigureSqlContext(this IServiceCollection services,
    IConfiguration configuration) =>
    services.AddDbContext<DataContext>(opts =>
    opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

    /// <summary>
    /// Används för att injecera de olika serviceses som finns. Gjord för att förenkla koden i Program
    /// </summary>
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
