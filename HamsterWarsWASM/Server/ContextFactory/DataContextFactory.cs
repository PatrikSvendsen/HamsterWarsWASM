using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HamsterWarsWASM.Server.ContextFactory;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    /// <summary>
    /// För att skapa DbContext kopplingen samt hämta ConnectionString 
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public DataContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
        var builder = new DbContextOptionsBuilder<DataContext>()
        .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
            b => b.MigrationsAssembly("HamsterWarsWASM.Server"));

        return new DataContext(builder.Options);
    }
}

