using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CleanseBlog.Models
{
    public class Makale
    {
        public Makale()
        {
            Etikets = new List<Etiket>();
        }
        public int id { get; set; }
        public string baslik { get; set; }
        public string icerik { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Yayın Tarihi")]
        public DateTime yayinTarihi { get; set; }

        public int kategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        [Index(IsUnique = true)]
        public int yazarId { get; set; }
        public virtual Yazar Yazar { get; set; }

        public int resimId { get; set; }
        public virtual Resim Resim { get; set; }

        public int goruntulenme { get; set; }
        public int begeni { get; set; }

        public virtual List<Etiket> Etikets { get; set; }
    }
}