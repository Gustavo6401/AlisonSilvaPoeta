using AlisonSilvaIdentityUser.Interfaces.Services.Base;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.ViewModels;

namespace AlisonSilvaIdentityUser.Interfaces.Services
{
    public interface ILivroServices : IServicesBase<LivroViewModel, Livro>
    {
        Task<LivroViewModel> GetLivroByProductId(int id);
    }
}
