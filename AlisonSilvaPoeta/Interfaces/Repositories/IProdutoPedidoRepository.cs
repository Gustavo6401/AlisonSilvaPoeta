﻿using AlisonSilvaPoeta.Interfaces.Repositories.Base;
using AlisonSilvaPoeta.Models;

namespace AlisonSilvaPoeta.Interfaces.Repositories
{
    public interface IProdutoPedidoRepository : IRepository<ProdutoPedido>
    {
        Task<List<ProdutoPedido>> GetByCompraId(int id);
    }
}
