using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProdutoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Produto>>? ListarPorNome(string nome)
        {
            List<Produto>? listaProdutos = await _dbContext.Produtos.Where(t => t.Titulo!.Contains(nome))
                                                            .ToListAsync();

            return listaProdutos!;
        }
    }
}
