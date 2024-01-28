using Microsoft.AspNetCore.Identity;

namespace AlisonSilvaPoeta.Models
{
    public class Logins : IdentityUserLogin<int>
    {
        public DateTime DataLogin { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
