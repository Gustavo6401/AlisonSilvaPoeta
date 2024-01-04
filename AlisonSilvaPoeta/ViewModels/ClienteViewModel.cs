using AlisonSilvaPoeta.Models;

namespace AlisonSilvaPoeta.ViewModels;

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

    public UsuarioViewModel? Usuario { get; set; }
    public int UsuarioId { get; set; }

    public ICollection<Endereco>? Enderecos { get; set; }
}
