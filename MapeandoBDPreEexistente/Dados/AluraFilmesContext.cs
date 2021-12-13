using MapeandoBDPreEexistente.Dados.Configuration;
using MapeandoBDPreEexistente.Negocio;
using Microsoft.EntityFrameworkCore;


namespace MapeandoBDPreEexistente.Dados
{
    public class AluraFilmesContext : DbContext
    {

        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeAtor> Elenco { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=iti-dev-01;Database=AluraFilmesRepl;Trusted_Connection=true;");
        }


        //quebrando as regras da conversão
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
            modelBuilder.ApplyConfiguration(new IdiomaConfiguration());
        }
    }
}
