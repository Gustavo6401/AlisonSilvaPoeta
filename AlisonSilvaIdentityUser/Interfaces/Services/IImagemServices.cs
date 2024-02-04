using AlisonSilvaIdentityUser.Interfaces.Services.Base;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.ViewModels;

namespace AlisonSilvaIdentityUser.Interfaces.Services
{
    public interface IImagemServices : IServicesBase<ImagemViewModel, Imagens>
    {
        Task<ImagemViewModel> ConsultarPorIdProduto(int id);
    }
}
