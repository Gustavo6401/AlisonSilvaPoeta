using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Models;

namespace AlisonSilvaIdentityUser.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {

        }
        public ClienteViewModel(int userId)
        {
            UsuarioId = userId;
        }
        public int Id { get; set; }

        public ApplicationUser? User { get; set; }
        public int UsuarioId { get; set; }

        public ICollection<Endereco>? Enderecos { get; set; }
    }
}
