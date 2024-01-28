using AlisonSilvaPoeta.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlisonSilvaPoeta;

public class LivrariaContext(DbContextOptions<LivrariaContext> options) : 
    IdentityDbContext<Usuario, Roles, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, 
        IdentityRoleClaim<int>, IdentityUserToken<int>>(options) 
{ 
    public DbSet<Roles>? Roles { get; set; }
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
        modelBuilder.Entity<Roles>().ToTable("Roles");

        modelBuilder.Entity<Roles>().HasKey(r => r.Id);

        modelBuilder.Entity<Roles>()
            .Property(r => r.NormalizedName)
                .HasMaxLength(20)
                    .IsRequired();

        modelBuilder.Entity<Usuario>().ToTable("Usuario");

        modelBuilder.Entity<Usuario>().HasKey(u => u.Id);

        modelBuilder.Entity<Usuario>()
            .Property(u => u.NormalizedUserName)
                .HasMaxLength(100)
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.NormalizedEmail)
                .HasMaxLength(255)
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.PasswordHash)
                .HasMaxLength(129)
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.PhoneNumber)
                .HasMaxLength(23)
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.RG)
                .HasColumnType("char(12)")
                    .IsRequired();

        modelBuilder.Entity<Usuario>()
            .Property(u => u.CPF)
                .HasColumnType("char(14)")
                    .IsRequired();

        modelBuilder.Entity<IdentityUserLogin<int>>().HasNoKey();

        modelBuilder.Entity<IdentityUserRole<int>>().HasNoKey();

        modelBuilder.Entity<IdentityUserToken<int>>().HasNoKey();

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

        modelBuilder.Entity<Roles>()
            .HasMany(r => r.Usuarios)
                .WithOne(u => u.Role)
                    .IsRequired()
                        .OnDelete(DeleteBehavior.NoAction);

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

    private void CadastrarRoles()
    {
        Roles.Add(new Models.Roles { Id = 0, Name = "Cliente", NormalizedName = "Administrador" });
        Roles.Add(new Models.Roles { Id = 0, Name = "Cliente", NormalizedName = "Cliente" });

        SaveChanges();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
}