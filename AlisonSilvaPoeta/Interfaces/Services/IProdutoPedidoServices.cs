﻿using AlisonSilvaPoeta.Interfaces.Services.Base;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.ViewModels;

namespace AlisonSilvaPoeta.Interfaces.Services;

public interface IProdutoPedidoServices : IServices<ProdutoPedidoViewModel, ProdutoPedido>
{
    Task<List<ProdutoPedidoViewModel>> GetByCompraId(int id);
}
