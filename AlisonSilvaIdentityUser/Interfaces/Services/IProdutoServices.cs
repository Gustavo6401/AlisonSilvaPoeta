using AlisonSilvaIdentityUser.Interfaces.Services.Base;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.ViewModels;

namespace AlisonSilvaIdentityUser.Interfaces.Services
{
    public interface IProdutoServices : IServicesBase<ProdutoViewModel, Produto>
    {
        Task<List<ProdutoViewModel>> ListarPorNome(string nome);
    }
}
