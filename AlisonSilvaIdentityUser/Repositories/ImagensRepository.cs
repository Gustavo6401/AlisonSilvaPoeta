using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class ImagensRepository : Repository<Imagens>, IImagensRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ImagensRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Imagens> GetImagemPadrao(int idProduto)
        {
            Imagens? imagens = await _dbContext.Imagens.FirstOrDefaultAsync(i => i.ProdutoId == idProduto
                                                           && i.ImagemPadrao == true);

            return imagens!;
        }
    }
}
