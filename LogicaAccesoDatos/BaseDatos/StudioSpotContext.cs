using LogicaNegocio.EntidadesNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.BaseDatos
{
    public class StudioSpotContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }


        public StudioSpotContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
                .HasDiscriminator<string>("Rol")
                .HasValue<Cliente>("Cliente")
                .HasValue<Administrador>("Administrador");

            modelBuilder.Entity<Usuario>().Property(u => u.Nombre).HasMaxLength(100);
            modelBuilder.Entity<Usuario>().Property(u => u.Apellido).HasMaxLength(100);
            modelBuilder.Entity<Usuario>().Property(u => u.Cedula).HasMaxLength(20);
            modelBuilder.Entity<Usuario>().Property(u => u.Email).HasMaxLength(100);
            modelBuilder.Entity<Usuario>().Property(u => u.Contrasena).HasMaxLength(255);
            modelBuilder.Entity<Usuario>().Property(u => u.WhatsApp).HasMaxLength(20);

            modelBuilder.Entity<Administrador>().Property(a => a.RUT).HasMaxLength(20);
            modelBuilder.Entity<Administrador>().Property(a => a.Direccion).HasMaxLength(200);
        }

    }
}
