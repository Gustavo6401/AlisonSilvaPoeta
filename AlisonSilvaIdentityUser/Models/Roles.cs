using AlisonSilvaIdentityUser.Data;
using Microsoft.AspNetCore.Identity;

namespace AlisonSilvaIdentityUser.Models
{
    public class Roles : IdentityRole<int>
    {
        public override int Id { get => base.Id; set => base.Id = value; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
