using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Models;

namespace AlisonSilvaPoeta.Interfaces.Repositories
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<List<Endereco>> GetEnderecosByClienteId(int id);
    }
}
