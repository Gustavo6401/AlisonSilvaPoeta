using AlisonSilvaPoeta;
using AlisonSilvaPoeta.Components;
using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Interfaces.Services;
using AlisonSilvaPoeta.Repositories;
using AlisonSilvaPoeta.Services.Cryptograph;
using AlisonSilvaPoeta.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var sqlServerConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<LivrariaContext>(context =>
    context.UseSqlServer(sqlServerConnection));

builder.Services.AddDbContext<LivrariaContext>(options =>
    options.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=AlisonSilvaPoeta;Trusted_Connection=True"
));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IUsuarioServices, UsuarioServices>();
builder.Services.AddScoped<IClienteServices, ClienteServices>();
builder.Services.AddSingleton<Sha512>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
