
using Microsoft.EntityFrameworkCore;
using Projeto_Web.Models;

namespace Projeto_Web.Data
{
    class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=JUN536737W10-1\\BDSENAC;Initial Catalog=BancoWeb;User Id=senaclivre;Password='senaclivre'");
        }
        public DbSet<CadastroModel> Clientes { get; set; }

    }
}
