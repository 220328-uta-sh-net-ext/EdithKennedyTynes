using CHBL;
using CHDL;


string connectionStringFilePath = "C:/Revature/Project_0/ChopHouseDraft/CHDL/Connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);
// app here refers to the pipeline middleware steps sequential request pass through and processed accordingly
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();//middleware

builder.Services.AddScoped<IRepository>(repo=>new SqlRepository(connectionString));//service call to within the scope

builder.Services.AddScoped<IChopHouseLogic, ChopHouseLogic>();

//builder.Services.AddScoped<IRepository>(repo => new SqlRepository(connectionString));
//builder.Services.AddScoped<IChopHouseLogic, ChopHouseLogic>();

var app = builder.Build();// app here refers to the pipeline middleware

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())// no error pages
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();//read from one page to another all .app are middleware

app.UseAuthorization();//security 

app.MapControllers();

app.Run();//middleware
