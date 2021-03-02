namespace Seicho.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbSgc : DbContext
    {
        public dbSgc()
            : base("name=dbSgc")
        {
        }

        public virtual DbSet<produtos> produtos { get; set; }
        public virtual DbSet<produtos_vendidos> produtos_vendidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<produtos>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<produtos>()
                .Property(e => e.INFO_ADICIONAIS)
                .IsUnicode(false);

            modelBuilder.Entity<produtos>()
                .Property(e => e.DT_ENTRADA)
                .IsUnicode(false);

            modelBuilder.Entity<produtos_vendidos>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);
        }
    }
}
