using CHBL;
using CHDL;

string connectinStrringFilePath = "C:/Revature/Project_0/ChopHouseDraft/CHDL/Connection-string.txt";
string connectinStrring = File.ReadAllText(connectinStrringFilePath);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IRepository>(repo => new SqlRepository(connectionString));
//builder.Services.AddScoped<IChopHouseLogic, ChopHouseLogic>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
