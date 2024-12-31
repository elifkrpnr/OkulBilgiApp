using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OkulBilgiApp
{
    internal class OkulDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> TblDersler { get; set; }
        public DbSet<OgrenciDers> TblOgrenciDers { get; set; }
        public DbSet<Sinif> TblSiniflar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=OkulBilgiDbProject;Integrated Security=true;TrustServerCertificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ogrenci>()
                .HasOne(o => o.Sinif)
                .WithMany(s => s.Ogrenciler)
                .HasForeignKey(o => o.SinifId);

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ogrenci)
                .WithMany(o => o.OgrenciDersler)
                .HasForeignKey(od => od.OgrenciId);

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ders)
                .WithMany(d => d.OgrenciDersler)
                .HasForeignKey(od => od.DersId);

            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Numara).HasColumnType("varchar").HasMaxLength(10).IsRequired();

            modelBuilder.Entity<Ders>().Property(o => o.DersKod).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ders>().Property(o => o.DersAd).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            modelBuilder.Entity<Sinif>().Property(o => o.SinifAd).HasColumnType("varchar").HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Sinif>().Property(o => o.Kontenjan).HasColumnType("varchar").HasMaxLength(10).IsRequired();
        }
    }
}
