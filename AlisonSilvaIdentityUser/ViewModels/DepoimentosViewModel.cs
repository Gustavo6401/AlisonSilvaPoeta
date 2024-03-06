using AlisonSilvaIdentityUser.Data;

namespace AlisonSilvaIdentityUser.ViewModels
{
    public class DepoimentosViewModel
    {
        public int Id { get; set; }
        public string? Texto { get; set; }
        public DateTime? DataPostagem { get; set; }

        public ApplicationUser? Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
