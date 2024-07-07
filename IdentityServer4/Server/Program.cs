using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Server.Data;

var builder = WebApplication.CreateBuilder(args);

// We get name of assembly||Get the current assembly|| Program is class name we are in
var assembly = typeof(Program).Assembly.GetName().Name;

//Conection String
var defaultConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register ApplicationDBContext
builder.Services.AddDbContext<IdentityApplicationDBContext>(options => 
    options.UseSqlServer(defaultConnectionString,b=>b.MigrationsAssembly(assembly)));

// Register IdentityApplicationDBContext for ASP.NET Core Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<IdentityApplicationDBContext>();

//Register Identity Server Services
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
