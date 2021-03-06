using MapeandoBDPreEexistente.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MapeandoBDPreEexistente.Dados.Configuration
{
    public class AtorConfiguration : IEntityTypeConfiguration<Ator>
    {
        public void Configure(EntityTypeBuilder<Ator> builder)
        {
            //Ator
            builder
                 .ToTable("actor");

            builder
                .Property(a => a.Id)
                .HasColumnName("actor_id");

            builder
                .Property(a => a.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("nvarchar(55)")
                .IsRequired();

            builder
               .Property(a => a.UltimoNome)
               .HasColumnName("last_name")
               .HasColumnType("nvarchar(55)")
               .IsRequired();

            builder
              .Property<DateTime>("last_update") //propriedade a ser configurada é uma shadow property, ou seja ela, não existe na classe de negócio
              .HasColumnType("datetime")
              .HasDefaultValueSql("getdate()") //Setando um valor padão  para Property Shadow Property
              .IsRequired();
        }       
    }
}
