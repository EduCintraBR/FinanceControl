using FinanceControl.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Api.Data
{
    public class FCDbContext : IdentityDbContext<AppUser>
    {
        public FCDbContext(DbContextOptions<FCDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(l => new { l.LoginProvider, l.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(ur => new { ur.UserId, ur.RoleId });
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(ut => new { ut.UserId, ut.LoginProvider, ut.Name });

            modelBuilder.Entity<Custos>()
                .HasOne(c => c.Controle)
                .WithMany(c => c.ListaCustos)
                .HasForeignKey(c => c.CodControle);

            modelBuilder.Entity<Ganhos>()
                .HasOne(c => c.Controle)
                .WithMany(c => c.ListaGanhos)
                .HasForeignKey(c => c.CodControle);

            modelBuilder.Entity<Parcela>()
                .HasOne(p => p.Custos)
                .WithMany(c => c.Parcelas)
                .HasForeignKey(p => p.CodCusto);

            modelBuilder.Entity<Parcela>()
                .HasOne(p => p.Parcelamento)
                .WithMany(c => c.Parcelas)
                .HasForeignKey(p => p.CodParcelamento);

            modelBuilder.Entity<Parcelamento>()
                .HasOne(p => p.Cartao)
                .WithMany(c => c.Parcelamentos)
                .HasForeignKey(p => p.CodCartao);
        }


        public DbSet<AppUser> Usuarios { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Controle> Controles { get; set; }
        public DbSet<Ganhos> Ganhos { get; set; }
        public DbSet<Custos> Custos { get; set; }
        public DbSet<Parcelamento> Parcelamento { get; set; }
        public DbSet<Parcela> Parcela { get; set; }
    }
}
