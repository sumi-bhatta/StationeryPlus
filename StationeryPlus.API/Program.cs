using Microsoft.EntityFrameworkCore;
using StationeryPlus.DataAccess.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDBContext>(options=>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();


app.Run();
