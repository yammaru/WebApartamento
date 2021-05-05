using Entidades;
using Microsoft.EntityFrameworkCore;
namespace Datos
{
    public class ApartamentosContext : DbContext
    {
        public ApartamentosContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Apartamento> Apartamentoss { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Arriendo> Arriendos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
