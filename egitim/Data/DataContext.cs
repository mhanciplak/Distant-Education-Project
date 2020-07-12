using egitim.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Data
{
    public class DataContext:DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<admin> admins { get; set; }
        public DbSet<dersler> derslers { get; set; }
        public DbSet<konular> konulars { get; set; }
        public DbSet<ogrenci> ogrencis { get; set; }
        public DbSet<sinav> sinavs { get; set; }
        public DbSet<odev> odevs { get; set; }
        public DbSet<cevaplar> cevaplars { get; set; }
        public DbSet<canli> canli { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>().ToTable("admin_table");
            modelBuilder.Entity<dersler>().ToTable("dersler_table");
            modelBuilder.Entity<konular>().ToTable("konular_table");
            modelBuilder.Entity<ogrenci>().ToTable("ogrenci_table");
            modelBuilder.Entity<odev>().ToTable("odev_table");
            modelBuilder.Entity<sinav>().ToTable("sinav_table");
            modelBuilder.Entity<cevaplar>().ToTable("cevaplar_table");
            modelBuilder.Entity<canli>().ToTable("canli_table");

        }
    }
}
