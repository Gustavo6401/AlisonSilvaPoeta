namespace AlisonSilvaIdentityUser.Models
{
    public class Imagens
    {
        public int Id { get; set; }
        public string? Link { get; set; }
        public bool ImagemPadrao { get; set; }

        public Produto? Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}
