using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie13.Models
{
    public class CukierniaContext : DbContext

    {
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Pracownik> Pracownik { get; set; }
        public DbSet<WyrobCukierniczy> WyrobCukierniczy { get; set; }
        public DbSet<Zamowienie> Zamowienie { get; set; }

        public CukierniaContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>()
                .HasKey(entity => new { entity.IdZamowienia, entity.IdWyrobuCukierniczego });


        }
    }
}
