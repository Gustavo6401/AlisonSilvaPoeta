namespace AlisonSilvaPoeta.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }

        public ICollection<Endereco>? Enderecos { get; set; }
    }
}
