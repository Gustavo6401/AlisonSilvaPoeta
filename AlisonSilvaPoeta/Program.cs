using AlisonSilvaPoeta;
using AlisonSilvaPoeta.Components;
using AlisonSilvaPoeta.Interfaces.Cryptograph;
using AlisonSilvaPoeta.Interfaces.Login;
using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Interfaces.Services;
using AlisonSilvaPoeta.Repositories;
using AlisonSilvaPoeta.Services.Authentication;
using AlisonSilvaPoeta.Services.Cryptograph;
using AlisonSilvaPoeta.Services.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthenticationCore();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var sqlServerConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<LivrariaContext>(context =>
    context.UseSqlServer(sqlServerConnection));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<ICompraRepository, CompraRepository>();
builder.Services.AddScoped<IProdutoPedidoRepository, ProdutoPedidoRepository>();

builder.Services.AddScoped<IUsuarioServices, UsuarioServices>();
builder.Services.AddScoped<IClienteServices, ClienteServices>();
builder.Services.AddScoped<IProdutoServices, ProdutoServices>();
builder.Services.AddScoped<ILivroServices, LivroServices>();
builder.Services.AddScoped<IEnderecoServices, EnderecoServices>();
builder.Services.AddScoped<ICompraServices, CompraServices>();
builder.Services.AddScoped<IProdutoPedidoServices, ProdutoPedidoServices>();

builder.Services.AddScoped<ISha512, Sha512>();
builder.Services.AddScoped<ILoginServices, LoginServices>();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<CustomAuthenticationStateProvider>();

// builder.Services.AddScoped<AuthenticationStateProvider>();
// builder.Services.AddScoped<NavigationManager>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
