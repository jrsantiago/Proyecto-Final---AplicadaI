using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
   public  class VentanaGzDb : DbContext
    {
        public VentanaGzDb() : base("Name=VentanaDb")
        {

        }

        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<ventanaAluminio> ventanaAluminio { get; set; }
        public virtual DbSet<FabricarVentanaAluminio> FabricarVentanaAluminio { get; set; }
        public virtual DbSet<Screens> Screens { get; set; }
        public virtual DbSet<FabricarScreen> FabricarScreen { get; set; }
        public virtual DbSet<Proyecto>Poyecto { get; set; }

        public virtual DbSet <Materiales> Materiales { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
               .HasMany<ventanaAluminio>(a => a.VentanaAluminio)
               .WithMany(p => p.cliente)
               .Map(pa =>
               {
                   pa.MapLeftKey("idCliente");
                   pa.MapRightKey("idAlumi");
                   pa.ToTable("Proyecto");
               });

            base.OnModelCreating(modelBuilder);
        }
    }
}
