using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Models;

namespace AlisonSilvaPoeta.Interfaces.Repositories;

public interface ILivroRepository : IRepository<Livro>
{
    Task<Livro> GetByProductId(int id);
}
