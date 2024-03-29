﻿using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Models;

namespace AlisonSilvaPoeta.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> Login(string email, string senha);
    }
}
