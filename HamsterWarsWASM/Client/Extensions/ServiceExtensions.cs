namespace HamsterWarsWASM.Client.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        //-----------|  Services
        services.AddScoped<IHamsterService, HamsterService>();
        services.AddScoped<IMatchService, MatchService>();
    }
}
