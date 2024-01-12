using AlisonSilvaPoeta.Models;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaPoeta;

public class LivrariaContext : DbContext
{
    public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options) { }
    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Cliente>? Clientes { get; set; }
    public DbSet<Endereco> Endereco { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Imagens> Imagens { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<ProdutoPedido> ProdutoPedidos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>().HasKey(u => u.Id);

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Nome)
                .HasMaxLength(100)
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.EMail)
                .HasMaxLength(255)
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Senha)
                .HasMaxLength(129)
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Telefone)
                .HasMaxLength(23)
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.Permisao)
                .HasMaxLength(13)
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.RG)
                .HasColumnType("char(12)")
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.CPF)
                .HasColumnType("char(14)")
                    .IsRequired();

        modelBuilder.Entity<Cliente>().HasKey(c => c.Id);

        modelBuilder.Entity<Endereco>().HasKey(e => e.Id);

        modelBuilder.Entity<Endereco>()
            .Property(e => e.CEP)
                .HasColumnType("char(9)")
                    .IsRequired();

        modelBuilder.Entity<Endereco>()
            .Property(e => e.Rua)
                .HasMaxLength(150)
                    .IsRequired();

        modelBuilder.Entity<Endereco>()
            .Property(e => e.Numero)
                .IsRequired();

        modelBuilder.Entity<Endereco>()
            .Property(e => e.Bairro)
                .HasMaxLength(50)
                    .IsRequired();

        modelBuilder.Entity<Endereco>()
            .Property(e => e.Cidade)
                .HasMaxLength(34)
                    .IsRequired();

        modelBuilder.Entity<Endereco>()
            .Property(e => e.UF)
                .HasColumnType("char(2)")
                    .IsRequired();

        modelBuilder.Entity<Produto>().HasKey(p => p.Id);

        modelBuilder.Entity<Produto>()
            .Property(p => p.Titulo)
                .HasMaxLength(35)
                    .IsRequired();

        modelBuilder.Entity<Produto>()
            .Property(p => p.Descricao)
                .HasMaxLength(500)
                    .IsRequired();

        modelBuilder.Entity<Produto>()
            .Property(l => l.Preco)
                .HasPrecision(5, 2)
                    .IsRequired();

        modelBuilder.Entity<Produto>()
            .Property(l => l.Custo)
                .HasPrecision(5, 2)
                    .IsRequired();

        modelBuilder.Entity<Produto>()
            .Property(p => p.CodigoBarras)
                .HasMaxLength(35);

        modelBuilder.Entity<Livro>().HasKey(l => l.Id);

        modelBuilder.Entity<Livro>()
            .Property(l => l.ISBN)
                .HasColumnType("char(17)")
                    .IsRequired();

        modelBuilder.Entity<Livro>()
            .Property(l => l.NumeroPaginas);

        modelBuilder.Entity<Imagens>().HasKey(i => i.Id);

        modelBuilder.Entity<Imagens>()
            .Property(i => i.Link)
                .HasMaxLength(255)
                    .IsRequired();

        modelBuilder.Entity<Imagens>()
            .Property(i => i.ImagemPadrao)
                .IsRequired();

        modelBuilder.Entity<Compra>().HasKey(c => c.Id);

        modelBuilder.Entity<Compra>()
            .Property(c => c.DataCompra)
                .IsRequired();

        modelBuilder.Entity<Compra>()
            .Property(c => c.Total)
                .HasPrecision(7,2)
                    .IsRequired();

        modelBuilder.Entity<Compra>()
            .Property(c => c.FormaPagamento)
                .HasMaxLength(17)
                    .IsRequired();

        modelBuilder.Entity<Compra>()
            .Property(c => c.Status)
                .HasMaxLength(12)
                    .IsRequired();

        modelBuilder.Entity<ProdutoPedido>().HasKey(pp => pp.Id);

        modelBuilder.Entity<ProdutoPedido>()
            .Property(pp => pp.QtdVendida)
                .IsRequired();

        modelBuilder.Entity<Usuario>()
            .HasOne(u => u.Cliente)
                .WithOne(c => c.Usuario)
                    .HasForeignKey<Cliente>(c => c.UsuarioId)
                         .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Cliente>()
            .HasMany(c => c.Enderecos)
                .WithOne(e => e.Cliente)
                    .IsRequired()
                        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Produto>()
            .HasOne(p => p.Livro)
                .WithOne(l => l.Produto)
                    .HasForeignKey<Livro>(l => l.ProdutoId)
                        .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<Produto>()
            .HasMany(l => l.Imagens)
                .WithOne(i => i.Produto)
                    .IsRequired()
                        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Produto>()
            .HasMany(l => l.Compras)
                .WithMany(c => c.Produtos)
                    .UsingEntity<ProdutoPedido>();

        modelBuilder.Entity<Compra>()
            .HasOne(c => c.Endereco)
                .WithMany(e => e.Compras)
                    .IsRequired()
                        .OnDelete(DeleteBehavior.Cascade);
    }
}