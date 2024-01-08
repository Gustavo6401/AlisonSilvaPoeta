using AlisonSilvaPoeta.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace AlisonSilvaPoeta.Services.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ProtectedSessionStorage? ProtectedSessionStorage { get; }
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
        {
            ProtectedSessionStorage = sessionStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var userSessionStorageResult = await ProtectedSessionStorage.GetAsync<UsuarioViewModel>("UserSession");
            var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;

            if (userSession == null)
                return await Task.FromResult(new AuthenticationState(_anonymous));

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, Convert.ToString(userSession.Id)),
                new Claim(ClaimTypes.Name, userSession.Nome),
                new Claim(ClaimTypes.Role, userSession.Permisao)
            }, "CustomAuth"));

            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }

        public async Task UpdateAuthenticationState(UsuarioViewModel user)
        {
            ClaimsPrincipal claimsPrincipal;

            if(user != null)
            {
                await ProtectedSessionStorage.SetAsync("UserSession", user);

                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, Convert.ToString(user.Id)),
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.Role, user.Permisao)
                }, "CustomAuth"));
            }
            else
            {
                await ProtectedSessionStorage.DeleteAsync("UserSession");

                claimsPrincipal = _anonymous;
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
    }
}
