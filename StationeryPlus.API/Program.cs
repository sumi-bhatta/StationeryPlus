using Microsoft.EntityFrameworkCore;
using StationeryPlus.DataAccess.Data;

var builder = WebApplication.CreateBuilder(args);
using StationeryPlus.Business.Misc;
using StationeryPlus.DataAccess.Data;
using StationeryPlus.IBusiness.Misc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDBContext>(options=>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

builder.Services.AddScoped<IStationeryPlusService, StationeryPlusService>();
var app = builder.Build();

app.MapControllers();
app.Run();
