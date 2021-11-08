using Envios.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Envios.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=Connection")
        {
        }

        public virtual DbSet<Localidades> Localidades { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paises>()
                .HasMany(e => e.Provincias)
                .WithRequired(e => e.Paises)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Provincias>()
                .HasMany(e => e.Localidades)
                .WithRequired(e => e.Provincias)
                .WillCascadeOnDelete(false);
        }
    }
}
