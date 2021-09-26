using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace БиблиотекаБГУИР
{
    public partial class Library : DbContext
    {
        public Library()
            : base("name=Library")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Авторы> Авторы { get; set; }
        public virtual DbSet<Адреса> Адреса { get; set; }
        public virtual DbSet<Библиотекари> Библиотекари { get; set; }
        public virtual DbSet<Карта_Читателя> Карта_Читателя { get; set; }
        public virtual DbSet<Категории> Категории { get; set; }
        public virtual DbSet<Книги> Книги { get; set; }
        public virtual DbSet<Статусы> Статусы { get; set; }
        public virtual DbSet<Учёт> Учёт { get; set; }
        public virtual DbSet<Читатели> Читатели { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Авторы>()
                .HasMany(e => e.Книги)
                .WithRequired(e => e.Авторы)
                .HasForeignKey(e => e.Автор_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Адреса>()
                .HasMany(e => e.Читатели)
                .WithRequired(e => e.Адреса)
                .HasForeignKey(e => e.Адрес_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Карта_Читателя>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Категории>()
                .HasMany(e => e.Книги)
                .WithOptional(e => e.Категории)
                .HasForeignKey(e => e.Категория_ID);

            modelBuilder.Entity<Книги>()
                .HasMany(e => e.Учёт)
                .WithRequired(e => e.Книги)
                .HasForeignKey(e => e.Книга_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Статусы>()
                .HasMany(e => e.Учёт)
                .WithRequired(e => e.Статусы)
                .HasForeignKey(e => e.Статус_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Учёт>()
                .HasMany(e => e.Карта_Читателя)
                .WithRequired(e => e.Учёт)
                .HasForeignKey(e => e.Книга_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Читатели>()
                .HasMany(e => e.Карта_Читателя)
                .WithRequired(e => e.Читатели)
                .HasForeignKey(e => e.Читатель_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
