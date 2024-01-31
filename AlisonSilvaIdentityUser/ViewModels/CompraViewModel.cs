namespace AlisonSilvaIdentityUser.ViewModels
{
    public class CompraViewModel
    {
        public int Id { get; set; }
        public DateTime? DataCompra { get; set; }
        public decimal Total { get; set; }
        //public string? FormaPagamento { get; set; }
        public string? Status { get; set; }

        public EnderecoViewModel? Endereco { get; set; }
        public int EnderecoId { get; set; }

        public ICollection<LivroViewModel>? Produtos { get; set; }
    }
}
