using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AlisonSilvaPoeta.ViewModels
{
    public class DetalhesCompraViewModel
    {
        public DetalhesCompraViewModel()
        {
            
        }
        public DetalhesCompraViewModel(string titulo, decimal preco, int qtdVendida)
        {
            Titulo = titulo;
            Preco = preco;
            QtdVendida = qtdVendida;
        }

        [Required]
        [StringLength(50)]
        public string? Titulo { get; set; }
        [Required]
        [Precision(5, 2)]
        public decimal Preco { get; set; }
        public int QtdVendida { get; set; }
    }
}
