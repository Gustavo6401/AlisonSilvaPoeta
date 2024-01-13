namespace AlisonSilvaPoeta.Models
{
    public class ProdutoPedido
    {
        public ProdutoPedido()
        {
            
        }
        public ProdutoPedido(int id, int qtdVendida, int produtoId, int compraId)
        {
            Id = id;
            QtdVendida = qtdVendida;
            ProdutoId = produtoId;
            CompraId = compraId;
        }
        public int Id { get; set; }
        public int QtdVendida { get; set; }

        public Compra? Compra { get; set; }
        public int CompraId { get; set; }

        public Produto? Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}
