using Microsoft.AspNetCore.Identity;

namespace AlisonSilvaPoeta.Models
{
    public class Usuario : IdentityUser<int>
    {
        public Usuario()
        {
            
        }

        public Usuario(int id, string? nome, string? email, string? senha, string? telefone, string permisao,
            string? rg, string? cpf)
        {
            Id = id;
            NormalizedUserName = nome;
            NormalizedEmail = email;
            PasswordHash = senha;
            PhoneNumber = telefone;
            Role = new Roles(permisao);
            RG = rg;
            CPF = cpf;
        }
        public override int Id { get; set; }
        public override string? NormalizedUserName { get; set; }
        public override string? NormalizedEmail { get; set; }
        public override string? PasswordHash { get; set; }
        public override string? PhoneNumber { get; set; }
        [PersonalData]
        public string? RG { get; set; }
        [PersonalData]
        public string? CPF { get; set; }

        public Cliente? Cliente { get; set; }
        public Roles? Role { get; set; }
        public ICollection<Logins> Logins { get; set; }

        public int RoleId { get; set; }
    }
}
