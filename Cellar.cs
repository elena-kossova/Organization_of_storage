using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Organization_of_storage
{
    public partial class Cellar : DbContext
    {
        public Cellar()
            : base("name=Cellar")
        {
        }

        public virtual DbSet<Container> Container { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Type_of_conservation> Type_of_conservation { get; set; }
        //public virtual DbSet<InBasket> InBasket { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Container>()
                .Property(e => e.Cap)
                .IsUnicode(false);

            modelBuilder.Entity<Container>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Container)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ingredients>()
                .Property(e => e.Component)
                .IsUnicode(false);

            modelBuilder.Entity<Ingredients>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Ingredients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Place)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Recipe)
                .IsUnicode(false);

            modelBuilder.Entity<Type_of_conservation>()
                .Property(e => e.Type_of_cons)
                .IsUnicode(false);

            modelBuilder.Entity<Type_of_conservation>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Type_of_conservation)
                .WillCascadeOnDelete(false);

            /*modelBuilder.Entity<InBasket>()
                .Property(e => e.CountB)
                .IsUnicode(false);

            modelBuilder.Entity<InBasket>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Type_of_conservation)
                .WillCascadeOnDelete(false);
            */
        }
    }
}
