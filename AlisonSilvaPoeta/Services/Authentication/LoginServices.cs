using AlisonSilvaPoeta.Interfaces.Login;
using AlisonSilvaPoeta.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace AlisonSilvaPoeta.Services.Authentication;

public class LoginServices : ILoginServices
{
    public async Task Login(HttpContext context, UsuarioViewModel usuario)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
            new Claim(ClaimTypes.Role, usuario.Permisao)
        };

        var claimsIdentity = new ClaimsPrincipal(
            new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
                ));

        var authProperties = new AuthenticationProperties
        {
            ExpiresUtc = DateTime.Now.AddHours(1),
            IssuedUtc = DateTime.Now
        };

        await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsIdentity, authProperties);
    }

    public async Task Logoff(HttpContext context)
    {
        await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}
