using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CEPEDI.Zebra.Web.Models
{
    public class ZebraDBContext : DbContext
    {
        public ZebraDBContext() : base("name=ZebraDB")
        { }

        public virtual DbSet<Impressora> Impressoras { get; set; }
        public virtual DbSet<Relatorio> Relatorios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Impressora>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Impressoras");
            });

            modelBuilder.Entity<Relatorio>()
                .Property(r => r._Parametros).HasColumnName("Parametros");

            modelBuilder.Entity<Relatorio>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Relatorios");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}