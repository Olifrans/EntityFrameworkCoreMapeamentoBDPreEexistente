﻿// <auto-generated />
using System;
using MapeandoBDPreEexistente.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MapeandoBDPreEexistente.Migrations
{
    [DbContext(typeof(AluraFilmesContext))]
    partial class AluraFilmesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MapeandoBDPreEexistente.Negocio.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("actor_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)")
                        .HasColumnName("first_name");

                    b.Property<string>("UltimoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("actor");
                });
#pragma warning restore 612, 618
        }
    }
}
