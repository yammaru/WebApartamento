﻿// <auto-generated />
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(ApartamentosContext))]
    [Migration("20210420225740_ArriedoCreate")]
    partial class ArriedoCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidades.Apartamento", b =>
                {
                    b.Property<string>("CodApartamento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Arriendo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Deposito")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaIngreso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodApartamento");

                    b.ToTable("Apartamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
