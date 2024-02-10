using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaIdentityUser.Repositories
{
    public class ImagensRepository : Repository<Imagens>, IImagensRepository
    {
        private readonly ApplicationDbContext _context;
        public ImagensRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Imagens>> GetByProductId(int id)
        {
            return await _context.Imagens.Where(i => i.ProdutoId.Equals(id)).ToListAsync();
        }
    }
}
