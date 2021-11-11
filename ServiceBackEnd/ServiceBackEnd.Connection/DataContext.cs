using ServiceBackEnd.Entities.Clases;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ServiceBackEnd.Connection
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=connection")
        {
        }

        public virtual DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
