using AgenciaViagens.Data.Map;
using AgenciaViagens.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciaViagens.Data
{
    public class AgenciaViagensDBContex:DbContext
    {
        public AgenciaViagensDBContex(DbContextOptions<AgenciaViagensDBContex> options)
            : base(options) 
        {

        }

        public DbSet<DestinoModel> Destinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DestinoModel>().HasData(
               new DestinoModel { Id = 1, Name = "Natal", Preco = "800"},
               new DestinoModel { Id = 2, Name = "Rio de Janeiro", Preco = "1800"},
               new DestinoModel { Id = 3, Name = "João Pessoa", Preco = "600"},
               new DestinoModel { Id = 4, Name = "São Paulo", Preco = "2500"}
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
