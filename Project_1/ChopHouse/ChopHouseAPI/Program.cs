using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ChopHouseAPI.Repository;
using CHBL;
using CHDL;
using System.Text;

string connectionStringFilePath = "C:/Revature/P1/ChopHouse/CHDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);
// app here refers to the pipeline middleware steps sequential request pass through and processed accordingly
var builder = WebApplication.CreateBuilder(args);
/// <summary>
/// Configuration method has access to configuration(s) received and are stored in a variable 
/// from here we can access appSetting.Json file JWT token informantion.
/// used with [Body] for the environment and configuration in which we are using 
/// </summary>
ConfigurationManager Config = builder.Configuration;

// Add services to the container.
builder.Services.AddAuthentication(options =>//Lambdas expression used; boilerplate code to start with token for JWT security configuration 
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;//to authenticate the path
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;// 

}).AddJwtBearer(o =>
{
    var key = Encoding.UTF8.GetBytes(Config["JWT:Key"]);//request the Key, Issuer, and Audience.. Encoding belongs to <using system.text> and is used to obtain Key from acceptance file
    o.SaveToken = true;                                //if in different language it will be encoded in UTF8
    o.TokenValidationParameters = new TokenValidationParameters//being too long "Microsoft.IdentityModel.Tokens.TokenValidationParameters"
    {                                                            //using TokenValidationParameters as a namespace
        ValidateIssuerSigningKey = true,
        ValidIssuer = Config["JWT:Issuer"],
        ValidAudience = Config["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateLifetime = true,// making sure lifetime is active and if not will issue a new JWT
        ValidateIssuer = false,
        ValidateAudience = false,
        /// <summary>
        /// boiler plate code checking if correct audience, issuer, and lifetime. While setting access request if correct/true 
        /// </summary>

    };
});
builder.Services.AddMemoryCache();
builder.Services.AddControllers(options =>
    options.RespectBrowserAcceptHeader = true
    )
    .AddXmlSerializerFormatters();//adding xml formatter 
/// <summary>
/// boiler plate code checking if setting access request if correct 
/// </summary>
builder.Services.AddControllers(options =>
    options.RespectBrowserAcceptHeader = true)
//,options.OutputFormatters.RemoveType<JsonFormatter>() example to only allow specific format 


.AddXmlSerializerFormatters();//making a call to adding xml formatter 


//aggressive caching to increase performance
builder.Services.AddMemoryCache();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();//middleware

builder.Services.AddScoped<IRepository>(repo => new SqlRepository(Config.GetConnectionString("connectionString")));//accesses app seettings
;//service call to within the scope

builder.Services.AddScoped<IChopHouseLogic, ChopHouseLogic>();
builder.Services.AddSingleton<IJWTManagerRepo, JWTManagerRepo>();//AddSingleton

//builder.Services.AddScoped<IRepository>(repo => new SqlRepository(connectionString));
//builder.Services.AddScoped<IChopHouseLogic, ChopHouseLogic>();

var app = builder.Build();// app here refers to the pipeline middleware
app.Logger.LogInformation("App Started");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())// no error pages
{

    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");

    });

}

app.UseHttpsRedirection();//read from one page to another all .app are middleware
app.UseCors(x => x
                .AllowAnyOrigin() //Allowing any origin until find fix
                                  //.SetIsOriginAllowed("http://127.0.0.1:4200")
                .AllowAnyMethod()
                .AllowAnyHeader()
                );
/// <summary>
///  basic auththorization created through JWT for the different roles
/// </summary>

app.UseAuthentication();

app.UseAuthorization();//security 

app.MapControllers();

app.Run();//middleware
