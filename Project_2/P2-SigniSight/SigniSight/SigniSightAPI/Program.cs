//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SigniSightDL;
using SigniSightBL;
using Microsoft.EntityFrameworkCore;
using Serilog;
using SigniSightAPI;


var builder = WebApplication.CreateBuilder();

Log.Logger = new LoggerConfiguration().CreateBootstrapLogger();

builder.Host.UseSerilog(((ctx, lc) => lc

.ReadFrom.Configuration(ctx.Configuration)));


/*Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateBootstrapLogger();
*/
ConfigurationManager config = builder.Configuration;

builder.Services.AddMemoryCache();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    //builder.Services.AddDbContext<SigniSightContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SighniSight")));

    builder.Services.AddScoped<IRepo>(repo => new SqlRepo(config.GetConnectionString("connectionString")));
    builder.Services.AddScoped<ILogic, Logic>();

    var app = builder.Build();
    app.UseSerilogRequestLogging();
    app.Logger.LogInformation("App Started");

    if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");

        });
    }
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }


app.UseHttpsRedirection();
    app.UseCors(x => x
                .AllowAnyOrigin() //Allowing any origin until find fix
                                  //.SetIsOriginAllowed("http://127.0.0.1:4200")
                .AllowAnyMethod()
                .AllowAnyHeader()
                );
    app.UseAuthorization();
    app.MapControllers();
    app.Run();


