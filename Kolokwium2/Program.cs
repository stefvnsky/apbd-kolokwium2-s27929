using Kolokwium2.Data;
using Kolokwium2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//add services to the container

builder.Services.AddControllers();

//konfiguracja bazy danych z appsettings.json

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<IDbService, DbService>();

var app = builder.Build();

//configure the HTTP request pipeline

app.UseAuthorization();     //Aktywuje filtr autoryzacji
app.MapControllers();       //wlacza routing dla endpointow Web API
app.Run();                  //uruchamia aplikacje