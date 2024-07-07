using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Get the current assembly// program is class name we are in//name of assembly we get
var assembly = typeof(Program).Assembly.GetName().Name;

//Conection String
var defaultConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//Register Identy Server Services

//
builder.Services.AddIdentityServer()
    .AddConfigurationStore(options =>
    {
       options.ConfigureDbContext = b =>
        b.UseSqlServer(defaultConnectionString, opt =>opt.MigrationsAssembly(assembly));
    })
    .AddOperationalStore(options =>
    {
        options.ConfigureDbContext = b =>
        b.UseSqlServer(defaultConnectionString, opt => opt.MigrationsAssembly(assembly));
    })
    .AddDeveloperSigningCredential();

var app = builder.Build();
app.UseIdentityServer();
app.Run();
