namespace AlisonSilvaIdentityUser.ViewModels
{
    public class ProdutoPedidoViewModel
    {
        public ProdutoPedidoViewModel()
        {

        }
        public ProdutoPedidoViewModel(int id, int qtdVendida, int produtoId, int compraId)
        {
            Id = id;
            QtdVendida = qtdVendida;
            ProdutoId = produtoId;
            CompraId = compraId;
        }
        public int Id { get; set; }
        public int QtdVendida { get; set; }

        public CompraViewModel? Compra { get; set; }
        public int CompraId { get; set; }

        public LivroViewModel? Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}
