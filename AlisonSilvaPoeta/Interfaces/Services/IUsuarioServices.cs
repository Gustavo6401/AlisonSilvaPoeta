using AlisonSilvaPoeta.Interfaces.Services.Base;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.ViewModels;

namespace AlisonSilvaPoeta.Interfaces.Services;

public interface IUsuarioServices : IServices<UsuarioViewModel, Usuario>
{
    Task<UsuarioViewModel> Login(string email, string senha);
}
