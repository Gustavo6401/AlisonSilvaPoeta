using AlisonSilvaPoeta.Interfaces.Services.Base;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.ViewModels;

namespace AlisonSilvaPoeta.Interfaces.Services
{
    public interface IClienteServices : IServices<ClienteViewModel, Cliente>
    {
        Task<ClienteViewModel> GetByUsuarioId(int id);
    }
}
