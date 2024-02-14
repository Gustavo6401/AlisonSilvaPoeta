using AlisonSilvaIdentityUser.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AlisonSilvaIdentityUser.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {

        }
        public ProdutoViewModel(int id, string titulo, string descricao, decimal preco, decimal frete, decimal custo)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            Frete = frete;
            Custo = custo;
        }
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Titulo { get; set; }
        [Required]
        [StringLength(200)]
        public string? Descricao { get; set; }
        [Required]
        [Precision(5, 2)]
        public decimal Preco { get; set; }
        [Required]
        [Precision(5, 2)]
        public decimal Frete { get; set; }
        [Required]
        [Precision(5, 2)]
        public decimal Custo { get; set; }
        [StringLength(50)]
        public string? CodigoBarras { get; set; }
        public Livro? Livro { get; set; }

        public decimal Total { get {
                return Frete + Preco;
            } }

        public ICollection<Imagens>? Imagens { get; set; }
        public ICollection<Compra>? Compras { get; set; }
    }
}
