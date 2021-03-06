// <auto-generated />
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
    [Migration("20210503073540_arriend1o")]
    partial class arriend1o
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
                    b.Property<string>("IdApartamento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Deposito")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ValorApartamento")
                        .HasColumnType("int");

                    b.HasKey("IdApartamento");

                    b.ToTable("Apartamentoss");
                });

            modelBuilder.Entity("Entidades.Arriendo", b =>
                {
                    b.Property<string>("IdArriendo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdApartamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdCliente")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MovimientoIdMovimiento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaDesalojo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaIngreso")
                        .HasColumnType("datetime2");

                    b.HasKey("IdArriendo");

                    b.HasIndex("IdCliente");

                    b.HasIndex("MovimientoIdMovimiento");

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

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("IdMovimiento");

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
                    b.HasOne("Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente");

                    b.HasOne("Entidades.Movimiento", "Movimiento")
                        .WithMany()
                        .HasForeignKey("MovimientoIdMovimiento");
                });
#pragma warning restore 612, 618
        }
    }
}
