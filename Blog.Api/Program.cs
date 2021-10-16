using Blog.Api.Contexts;
using IBM.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

/**
 * docker exec -i -e ASPNETCORE_HTTPS_PORT="49181" -w "/app" 1f994e563826817b664fd5218ce0ff22776b95700835663a4c9922cf632aad95 sh -c ""dotnet" --additionalProbingPath /root/.nuget/fallbackpackages3 --additionalProbingPath /root/.nuget/fallbackpackages --additionalProbingPath /root/.nuget/fallbackpackages2  \"/app/bin/x64/Debug/net6.0/Blog.Api.dll\" --network blog | tee /dev/console"
 * docker run -dt -e "ASPNETCORE_ENVIRONMENT=Production" -e "ASPNETCORE_URLS=https://+:443;http://+:80" -e "DOTNET_USE_POLLING_FILE_WATCHER=1"  -P --name Blog.Api --link db2server blogapi:latest 
 */
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var config = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Blog.Api", Version = "v1" });
});
builder.Services.AddDbContext<ShadbContext>(options =>
{
    options.UseDb2(config.GetConnectionString("Localhost"), x => x.SetServerInfo(IBMDBServerType.LUW));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blog.Api v1"));
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
