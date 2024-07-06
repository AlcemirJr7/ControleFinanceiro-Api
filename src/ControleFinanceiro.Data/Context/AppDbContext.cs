using ControleFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<TipoReceita> TipoReceitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<TipoDespesa> TipoDespesas { get; set; }

    }
}
