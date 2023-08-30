using FinanceControl.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Api.Data
{
    public class FCDbContext : DbContext
    {
        public FCDbContext(DbContextOptions<FCDbContext> options) : base(options) { }

        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Controle> Controles { get; set; }
        public DbSet<Ganhos> Ganhos { get; set; }
        public DbSet<Custos> Custos { get; set; }
        public DbSet<Parcelamento> Parcelamento { get; set; }
        public DbSet<Parcela> Parcela { get; set; }
    }
}
