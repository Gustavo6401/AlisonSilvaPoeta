using AlisonSilvaIdentityUser.Data;

namespace AlisonSilvaIdentityUser.Models
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public Cliente(int userId)
        {
            UsuarioId = userId;
        }
        public int Id { get; set; }

        public ApplicationUser? Usuario { get; set; }
        public int UsuarioId { get; set; }

        public ICollection<Endereco>? Enderecos { get; set; }
    }
}
