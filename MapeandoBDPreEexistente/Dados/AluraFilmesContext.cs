using MapeandoBDPreEexistente.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MapeandoBDPreEexistente.Dados
{
    public class AluraFilmesContext : DbContext
    {

        public DbSet<Ator> Atores { get; set; }
        //public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=iti-dev-01;Database=AluraFilmesRepl;Trusted_Connection=true;");
        }


        //quebrando as regras da conversão
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ator>()
                 .ToTable("actor");

            modelBuilder.Entity<Ator>()
                .Property(a => a.Id)
                .HasColumnName("actor_id");

            modelBuilder.Entity<Ator>()
                .Property(a => a.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("nvarchar(55)")
                .IsRequired();

            modelBuilder.Entity<Ator>()
               .Property(a => a.UltimoNome)
               .HasColumnName("last_name")
               .HasColumnType("nvarchar(55)")
               .IsRequired();

            modelBuilder.Entity<Ator>()
              .Property<DateTime>("last_update") //propriedade a ser configurada é uma shadow property, ou seja ela, não existe na classe de negócio
              .HasColumnType("datetime")

              .HasDefaultValueSql("getdate()") //Pegando valores de uma propriedade shadow property

              .IsRequired();
        }
    }
}
