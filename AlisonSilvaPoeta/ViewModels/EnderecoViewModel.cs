using AlisonSilvaPoeta.Models;
using System.ComponentModel.DataAnnotations;

namespace AlisonSilvaPoeta.ViewModels
{
    public class EnderecoViewModel
    {
        public int Id { get; set; }
        [StringLength(9)]
        [Required]
        public string? CEP { get; set; }
        [Required]
        [StringLength(100)]
        public string? Rua { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        [StringLength(50)]
        public string? Bairro { get; set; }
        [Required]
        [StringLength(34)]
        public string? Cidade { get; set; }
        [Required]
        [StringLength(2)]
        public string? UF { get; set; }

        public Cliente? Cliente { get; set; }
        public int ClienteId { get; set; }

        public ICollection<Compra>? Compras { get; set; }
    }
}
