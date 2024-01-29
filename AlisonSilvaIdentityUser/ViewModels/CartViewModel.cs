using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AlisonSilvaIdentityUser.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel()
        {

        }

        public CartViewModel(int idProduto, string nome, string codBarras, decimal preco, int quantidade)
        {
            IdProduto = idProduto;
            Nome = nome;
            CodBarras = codBarras;
            Preco = preco;
            Quantidade = quantidade;
        }
        public int IdProduto { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Nome { get; set; }
        [Required]
        [MaxLength(50)]
        public string? CodBarras { get; set; }
        [Required]
        [Precision(5, 2)]
        public decimal Preco { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Precision(7, 2)]
        public decimal Total { get { return Quantidade * Preco; } }
    }
}
