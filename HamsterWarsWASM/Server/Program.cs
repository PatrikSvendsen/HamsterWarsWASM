global using DataAccess.EFCore;
global using DataAccess.EFCore.Services.HamsterService;
global using DataAccess.EFCore.Services.MatchService;
global using HamsterWarsWASM.Shared.Entities;
global using HamsterWarsWASM.Shared.Service;
using HamsterWarsWASM.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureServices(builder.Configuration);

builder.Services.AddEndpointsApiExplorer(); // Swagger
builder.Services.AddSwaggerGen(); // Swagger

var app = builder.Build();

app.UseSwaggerUI(); // Swagger

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger(); // Swagger

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
