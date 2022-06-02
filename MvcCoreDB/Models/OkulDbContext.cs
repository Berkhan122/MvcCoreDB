using Microsoft.EntityFrameworkCore;

namespace MvcCoreDB.Models
{

    public class OkulDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OkulAppDbSube2;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");
            modelBuilder.Entity<Ogretmen>().ToTable("tblOgretmenler");

            modelBuilder.Entity<Ogretmen>().Property(o=>o.Name).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogretmen>().Property(o=>o.Surname).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().HasIndex(o => o.Numara).IsUnique();
        }
    }
}
