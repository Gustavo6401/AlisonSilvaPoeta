using AlisonSilvaIdentityUser.Interfaces.Services.Base;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.ViewModels;

namespace AlisonSilvaIdentityUser.Interfaces.Services
{
    public interface IClienteServices : IServicesBase<ClienteViewModel, Cliente>
    {
        Task<ClienteViewModel> GetByUsuarioId(int id);
    }
}
