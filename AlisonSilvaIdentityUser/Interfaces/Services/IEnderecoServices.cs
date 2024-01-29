using AlisonSilvaIdentityUser.Interfaces.Services.Base;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.ViewModels;

namespace AlisonSilvaIdentityUser.Interfaces.Services
{
    public interface IEnderecoServices : IServicesBase<EnderecoViewModel, Endereco>
    {
        Task<List<EnderecoViewModel>> GetEnderecosByClienteId(int id);
    }
}
