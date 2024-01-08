namespace AlisonSilvaPoeta.Models;

public class Livro
{
    public int Id { get; set; }
    public string? ISBN { get; set; }
    public int NumeroPaginas { get; set; }

    public Produto? Produto { get; set; }
    public int ProdutoId { get; set; }
}
