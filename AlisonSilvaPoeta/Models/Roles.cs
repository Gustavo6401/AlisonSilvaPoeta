using Microsoft.AspNetCore.Identity;

namespace AlisonSilvaPoeta.Models
{
    public class Roles : IdentityRole<int>
    {
        public Roles() { }
        public Roles(string role)
        {
            NormalizedName = role;
        }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
