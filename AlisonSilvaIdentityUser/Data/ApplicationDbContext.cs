using AlisonSilvaIdentityUser.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AlisonSilvaIdentityUser.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
        IdentityDbContext<ApplicationUser, Roles, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>(options)
    {
        public DbSet<ApplicationUser>? ApplicationUsers { get; set; }
        public DbSet<Roles>? Roles { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Imagens> Imagens { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<ProdutoPedido> ProdutoPedidos { get; set; }
        public DbSet<Depoimentos> Depoimentos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //base.OnModelCreating(builder);

            builder.Entity<Roles>()
                .HasKey(u => u.Id);

            builder.Entity<ApplicationUser>()
                .HasKey(u => u.Id);

            builder.Entity<ApplicationUser>()
                .Property(u => u.NomeCompleto)
                    .HasMaxLength(150)
                        .IsRequired();

            builder.Entity<ApplicationUser>()
                .Property(u => u.RG)
                    .HasMaxLength(12)
                        .IsRequired();

            builder.Entity<ApplicationUser>()
                .Property(u => u.CPF)
                    .HasMaxLength(14)
            .IsRequired();

            builder.Entity<IdentityUserLogin<int>>().HasNoKey();

            builder.Entity<IdentityUserRole<int>>().HasNoKey();

            builder.Entity<IdentityUserToken<int>>().HasNoKey();

            builder.Entity<Cliente>().HasKey(c => c.Id);

            builder.Entity<Endereco>().HasKey(e => e.Id);

            builder.Entity<Endereco>()
                .Property(e => e.CEP)
                    .HasColumnType("char(9)")
                        .IsRequired();

            builder.Entity<Endereco>()
                .Property(e => e.Rua)
                    .HasMaxLength(150)
                        .IsRequired();

            builder.Entity<Endereco>()
                .Property(e => e.Numero)
                    .IsRequired();

            builder.Entity<Endereco>()
                .Property(e => e.Bairro)
                    .HasMaxLength(50)
                        .IsRequired();

            builder.Entity<Endereco>()
                .Property(e => e.Cidade)
                    .HasMaxLength(34)
                        .IsRequired();

            builder.Entity<Endereco>()
                .Property(e => e.UF)
                    .HasColumnType("char(2)")
                        .IsRequired();

            builder.Entity<Produto>().HasKey(p => p.Id);

            builder.Entity<Produto>()
                .Property(p => p.Titulo)
                    .HasMaxLength(35)
                        .IsRequired();

            builder.Entity<Produto>()
                .Property(p => p.Descricao)
                    .HasMaxLength(500)
                        .IsRequired();

            builder.Entity<Produto>()
                .Property(l => l.Preco)
                    .HasPrecision(5, 2)
                        .IsRequired();

            builder.Entity<Produto>()
                .Property(p => p.Frete)
                    .HasPrecision(5, 2);

            builder.Entity<Produto>()
                .Property(l => l.Custo)
                    .HasPrecision(5, 2)
                        .IsRequired();

            builder.Entity<Produto>()
                .Property(p => p.CodigoBarras)
                    .HasMaxLength(35);

            builder.Entity<Livro>().HasKey(l => l.Id);

            builder.Entity<Livro>()
                .Property(l => l.ISBN)
                    .HasColumnType("char(17)")
                        .IsRequired();

            builder.Entity<Livro>()
                .Property(l => l.NumeroPaginas);

            builder.Entity<Imagens>().HasKey(i => i.Id);

            builder.Entity<Imagens>()
                .Property(i => i.Link)
                    .HasMaxLength(255)
                        .IsRequired();

            builder.Entity<Imagens>()
                .Property(i => i.ImagemPadrao)
                    .IsRequired();

            builder.Entity<Compra>().HasKey(c => c.Id);

            builder.Entity<Compra>()
                .Property(c => c.DataCompra)
                    .IsRequired();

            builder.Entity<Compra>()
                .Property(c => c.Total)
                    .HasPrecision(7, 2)
                        .IsRequired();

            builder.Entity<Compra>()
                .Property(c => c.Status)
                    .HasMaxLength(25)
                        .IsRequired();

            builder.Entity<ProdutoPedido>().HasKey(pp => pp.Id);

            builder.Entity<ProdutoPedido>()
                .Property(pp => pp.QtdVendida)
                    .IsRequired();

            builder.Entity<Depoimentos>().HasKey(d => d.Id);

            builder.Entity<Depoimentos>()
                .Property(d => d.Texto)
                    .HasMaxLength(1000)
                        .IsRequired();

            builder.Entity<Depoimentos>()
                .Property(d => d.DataPostagem)
                    .IsRequired();

            builder.Entity<Roles>()
                .HasMany(r => r.Users)
                    .WithOne(u => u.Role)
                        .IsRequired()
                            .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ApplicationUser>()
            .HasOne(u => u.Cliente)
                .WithOne(c => c.Usuario)
                    .HasForeignKey<Cliente>(c => c.UsuarioId)
                         .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationUser>()
                .HasMany(a => a.Depoimentos)
                    .WithOne(d => d.Usuario)
                        .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Cliente>()
                .HasMany(c => c.Enderecos)
                    .WithOne(e => e.Cliente)
                        .IsRequired()
                            .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Produto>()
                .HasOne(p => p.Livro)
                    .WithOne(l => l.Produto)
                        .HasForeignKey<Livro>(l => l.ProdutoId)
                            .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<Produto>()
                .HasMany(l => l.Imagens)
                    .WithOne(i => i.Produto)
                        .IsRequired()
                            .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Produto>()
                .HasMany(l => l.Compras)
                    .WithMany(c => c.Produtos)
                        .UsingEntity<ProdutoPedido>();

            builder.Entity<Compra>()
                .HasOne(c => c.Endereco)
                    .WithMany(e => e.Compras)
                        .IsRequired()
                            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
