namespace AlisonSilvaIdentityUser.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime? DataCompra { get; set; }
        public decimal Total { get; set; }
        public string? FormaPagamento { get; set; }
        public string? Status { get; set; }

        public Endereco? Endereco { get; set; }
        public int EnderecoId { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
