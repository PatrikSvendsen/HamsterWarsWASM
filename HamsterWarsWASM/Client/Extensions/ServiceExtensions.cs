namespace HamsterWarsWASM.Client.Extensions;

public static class ServiceExtensions
{
    /// <summary>
    /// Service för att injecera de olika interfacen som finns. För att minimera text i program.cs
    /// </summary>
    public static void ConfigureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        //-----------|  Services
        services.AddScoped<IHamsterService, HamsterService>();
        services.AddScoped<IMatchService, MatchService>();
    }
}
