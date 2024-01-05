using AlisonSilvaPoeta.ViewModels;

namespace AlisonSilvaPoeta.Interfaces.Login;

public interface ILoginServices
{
    Task Login(HttpContext context, UsuarioViewModel usuario);
    Task Logoff(HttpContext context);
}
