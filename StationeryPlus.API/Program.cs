using Microsoft.EntityFrameworkCore;
using StationeryPlus.DataAccess.Data;
using StationeryPlus.Business.Misc;
using StationeryPlus.IBusiness.Misc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDBContext>(options=>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<IStationeryPlusService, StationeryPlusService>();
var app = builder.Build();

app.MapControllers();
app.Run();
