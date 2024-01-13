using AlisonSilvaPoeta.Models;

namespace AlisonSilvaPoeta.ViewModels
{
    public class CompraViewModel
    {
        public int Id { get; set; }
        public DateTime? DataCompra { get; set; }
        public decimal Total { get; set; }
        public string? FormaPagamento { get; set; }
        public string? Status { get; set; }

        public EnderecoViewModel? Endereco { get; set; }
        public int EnderecoId { get; set; }

        public ICollection<ProdutoViewModel>? Produtos { get; set; }
    }
}
