using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MarketBarkodApp.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }
        //birden fazla ürünü bir arada tutması için ıcollection kullandım.
        //veritabanında uruns olarak gözükecek.
        public ICollection<Urun> Uruns { get; set; }
    }
}