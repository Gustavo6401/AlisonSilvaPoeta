using AlisonSilvaIdentityUser.Models;
using Microsoft.AspNetCore.Identity;

namespace AlisonSilvaIdentityUser.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<int>
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        [PersonalData]
        public string? NomeCompleto { get; set; }
        [PersonalData]
        public string? RG { get; set; }
        [PersonalData]
        public string? CPF { get; set; }

        public Cliente? Cliente { get; set; }

        public Roles? Role { get; set; }
        public int RoleId { get; set; }
    }

}
