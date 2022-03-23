using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MarketBarkodApp.Models.Siniflar
{
    public class Context: DbContext
    {
        //TABLOLARA BURADAN ULAŞACAĞIM.

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cariler> Carilers { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<FaturaKalem> faturaKalems { get; set; }
        public DbSet<Faturalar> faturalars { get; set; }
        public DbSet<Gider> giders { get; set; }
        public DbSet<Kategori> kategoris { get; set; }
        public DbSet<Personel> personels { get; set; }
        public DbSet<SatisHareket> satisHarekets { get; set; }
        public DbSet<Urun> uruns { get; set; }
    }
}