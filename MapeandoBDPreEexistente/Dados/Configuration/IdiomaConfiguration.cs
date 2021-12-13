using MapeandoBDPreEexistente.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MapeandoBDPreEexistente.Dados.Configuration
{
    public class IdiomaConfiguration : IEntityTypeConfiguration<Idioma>
    {
        public void Configure(EntityTypeBuilder<Idioma> builder)
        {
            //Fimes
           builder
                 .ToTable("language");

           builder
                .Property(f => f.Id)
                .HasColumnName("language_id");

           builder
                .Property(a => a.Nome)
                .HasColumnName("name")
                .HasColumnType("char(20)")
                .IsRequired();


           builder
              .Property<DateTime>("last_update") //shadow property
              .HasColumnType("datetime")
              .HasDefaultValueSql("getdate()") //Setando um valor padão  para Property Shadow Property
              .IsRequired();
        }
    }
}
