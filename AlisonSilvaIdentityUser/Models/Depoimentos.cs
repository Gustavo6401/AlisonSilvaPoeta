using AlisonSilvaIdentityUser.Data;

namespace AlisonSilvaIdentityUser.Models;

public class Depoimentos
{
    public int Id { get; set; }
    public string? Texto { get; set; }
    public DateTime? DataPostagem { get; set; }

    public ApplicationUser? Usuario { get; set; }
    public int UsuarioId { get; set; }
}
