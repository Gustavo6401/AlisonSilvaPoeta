using static System.Net.Mime.MediaTypeNames;

namespace AlisonSilvaIdentityUser.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Custo { get; set; }
        public string? CodigoBarras { get; set; }
        public Livro? Livro { get; set; }

        public ICollection<Imagens>? Imagens { get; set; }
        public ICollection<Compra>? Compras { get; set; }
    }
}
