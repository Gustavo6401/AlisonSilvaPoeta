using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaPoeta.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private LivrariaContext DbContext;
        public UsuarioRepository(LivrariaContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<Usuario> Login(string email, string senha)
        {
            return await DbContext.Usuarios.FirstOrDefaultAsync(u => u.Nome.Equals(email)
                                                                &&   u.Senha.Equals(senha));
        }
    }
}
