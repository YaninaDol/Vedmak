using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Vedmak
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Personage> Personages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chapter>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Personage>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Personage>()
                .Property(e => e.Subscribe)
                .IsUnicode(false);

            modelBuilder.Entity<Personage>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Personage>()
                .Property(e => e.Race)
                .IsUnicode(false);

            modelBuilder.Entity<Personage>()
                .Property(e => e.Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<Personage>()
                .Property(e => e.Affination)
                .IsUnicode(false);

            modelBuilder.Entity<Personage>()
                .Property(e => e.Alive)
                .IsUnicode(false);
        }
    }
}
