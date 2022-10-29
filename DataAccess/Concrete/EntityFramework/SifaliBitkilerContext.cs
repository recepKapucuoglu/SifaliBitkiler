using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class SifaliBitkilerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SifaliBitkilerData;Trusted_Connection=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SikayetEtkiBitki>()
      .HasKey(ue => new { ue.SikayetEtkiId, ue.BitkiId });
            modelBuilder.Entity<SikayetEtkiBitki>()
                .HasOne(ue => ue.SikayetEtki)
                .WithMany(o => o.Bitkis)
                .HasForeignKey(ue => ue.SikayetEtkiId);
            modelBuilder.Entity<SikayetEtkiBitki>()
               .HasOne(q => q.Bitki)
              .WithMany(e => e.SikayetEtkis)
              .HasForeignKey(q => q.BitkiId);

  


        }


        public DbSet<Bitki> Bitkis { get; set; }

        public DbSet<SikayetEtki> SikayetEtkis { get; set; }

        public DbSet<SikayetEtkiBitki> SikayetEtkiBitki { get; set; }

    }
}