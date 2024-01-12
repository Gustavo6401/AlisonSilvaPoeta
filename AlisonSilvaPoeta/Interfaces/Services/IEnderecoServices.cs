using AlisonSilvaPoeta.Interfaces.Services.Base;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.ViewModels;

namespace AlisonSilvaPoeta.Interfaces.Services
{
    public interface IEnderecoServices : IServices<EnderecoViewModel, Endereco>
    {
        Task<List<EnderecoViewModel>> GetEnderecosByClienteId(int id);
    }
}
