using AlisonSilvaIdentityUser.Components;
using AlisonSilvaIdentityUser.Components.Account;
using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Interfaces.Services;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Models.MongoDBCollections.NoticiasDB;
using AlisonSilvaIdentityUser.Models.MongoDBCollections.PoesiasDB;
using AlisonSilvaIdentityUser.Repositories;
using AlisonSilvaIdentityUser.Repositories.MongoDBRepositories;
using AlisonSilvaIdentityUser.Services.Frete;
using AlisonSilvaIdentityUser.Services.MercadoPago;
using AlisonSilvaIdentityUser.Services.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<AlisonSilvaIdentityUser.Services.MercadoPago.CheckoutPro>();
builder.Services.AddScoped<FreteServices>();

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<IImagensRepository, ImagensRepository>();
builder.Services.AddScoped<ICompraRepository, ComprasRepository>();
builder.Services.AddScoped<IProdutoPedidoRepository, ProdutoPedidoRepository>();
builder.Services.AddScoped<IDepoimentoRepository, DepoimentoRepository>();
builder.Services.AddScoped<ApplicationUserRepository>();
builder.Services.AddScoped<PoesiaRepository>();

builder.Services.AddScoped<IClienteServices, ClienteServices>();
builder.Services.AddScoped<IProdutoServices, ProdutoServices>();
builder.Services.AddScoped<ILivroServices, LivroServices>();
builder.Services.AddScoped<IEnderecoServices, EnderecoServices>();
builder.Services.AddScoped<IComprasServices, CompraServices>();
builder.Services.AddScoped<IProdutoPedidoServices, ProdutoPedidoServices>();
builder.Services.AddScoped<IImagemServices, ImagemServices>();
builder.Services.AddScoped<IDepoimentoServices, DepoimentoServices>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "Auth";
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
});

builder.Services.Configure<NoticiasDbSettings>(builder.Configuration.GetSection("Noticias"));
builder.Services.Configure<PoesiasDbSettings>(builder.Configuration.GetSection("Poesias"));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString, 
    sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 10,
            maxRetryDelay: TimeSpan.FromMinutes(2),
            errorNumbersToAdd: null
        );
    }));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<Roles>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
