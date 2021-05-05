﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(ApartamentosContext))]
    [Migration("20210423214443_NuevoSchema")]
    partial class NuevoSchema
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

            modelBuilder.Entity("Entidades.Arriendo", b =>
                {
                    b.Property<string>("IdArriendo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdApartamento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdCliente")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdMovimiento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("fechaDeceso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaIngreso")
                        .HasColumnType("datetime2");

                    b.HasKey("IdArriendo");

                    b.HasIndex("IdApartamento");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdMovimiento");

                    b.ToTable("Arriendos");
                });

            modelBuilder.Entity("Entidades.Cliente", b =>
                {
                    b.Property<string>("IdCliente")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Entidades.Movimiento", b =>
                {
                    b.Property<string>("IdMovimiento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Detalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioIdUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("valor")
                        .HasColumnType("int");

                    b.HasKey("IdMovimiento");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Movimientos");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.Property<string>("IdUsuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Entidades.Arriendo", b =>
                {
                    b.HasOne("Entidades.Apartamento", "Apartamento")
                        .WithMany()
                        .HasForeignKey("IdApartamento");

                    b.HasOne("Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente");

                    b.HasOne("Entidades.Movimiento", "Movimiento")
                        .WithMany()
                        .HasForeignKey("IdMovimiento");
                });

            modelBuilder.Entity("Entidades.Movimiento", b =>
                {
                    b.HasOne("Entidades.Usuario", null)
                        .WithMany("Movimientos")
                        .HasForeignKey("UsuarioIdUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
