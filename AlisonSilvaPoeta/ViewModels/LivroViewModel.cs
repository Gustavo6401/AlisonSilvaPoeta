using AlisonSilvaPoeta.Models;
using System.ComponentModel.DataAnnotations;

namespace AlisonSilvaPoeta.ViewModels
{
    public class LivroViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(17)]
        public string? ISBN { get; set; }
        [Required]
        public int NumeroPaginas { get; set; }

        public Produto? Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}
