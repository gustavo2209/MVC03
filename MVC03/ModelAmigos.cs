using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVC03
{
    public partial class ModelAmigos : DbContext
    {
        public ModelAmigos()
            : base("name=ModelAmigos")
        {
        }

        public virtual DbSet<amigos> amigos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<amigos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<amigos>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<amigos>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<amigos>()
                .Property(e => e.direccion)
                .IsUnicode(false);
        }
    }
}
