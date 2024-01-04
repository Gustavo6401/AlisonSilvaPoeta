using AlisonSilvaPoeta.Models;

namespace AlisonSilvaPoeta.ViewModels;

public class UsuarioViewModel
{
    public UsuarioViewModel()
    {

    }

    public UsuarioViewModel(int id, string? nome, string? email, string? senha, string? telefone, 
        string? permisao, string? rg, string? cpf)
    {
        Id = id;
        Nome = nome;
        EMail = email;
        Senha = senha;
        Telefone = telefone;
        Permisao = permisao;
        RG = rg;
        CPF = cpf;
    }
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? EMail { get; set; }
    public string? Senha { get; set; }
    public string? Telefone { get; set; }
    public string? Permisao { get; set; }
    public string? RG { get; set; }
    public string? CPF { get; set; }

    public Cliente? Cliente { get; set; }
}
