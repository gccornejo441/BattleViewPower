using BattleViewPower.Contacts;
using BattleViewPower.Context;
using BattleViewPower.Repository;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var conStrBuilder = new NpgsqlConnectionStringBuilder(
//        builder.Configuration.GetConnectionString("connectionString"));
//conStrBuilder.Password = builder.Configuration["DbPassword"];
//var connection = conStrBuilder.ConnectionString;

builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
