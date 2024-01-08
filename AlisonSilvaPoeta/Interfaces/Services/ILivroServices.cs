using AlisonSilvaPoeta.Interfaces.Services.Base;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.ViewModels;

namespace AlisonSilvaPoeta.Interfaces.Services
{
    public interface ILivroServices : IServices<LivroViewModel, Livro>
    {
        Task<LivroViewModel> GetLivroByProductId(int id);
    }
}
