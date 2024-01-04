namespace AlisonSilvaPoeta.Models
{
    public class ProdutoPedido
    {
        public int Id { get; set; }
        public int QtdVendida { get; set; }

        public Compra? Compra { get; set; }
        public int CompraId { get; set; }

        public Produto? Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}
