using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CleanseBlog.Models
{
    public class Resim
    {
        public int id { get; set; }
        public string adi { get; set; }
        public string kckResimYol { get; set; }
        public string ortResimYol { get; set; }
        public string bykResimYol { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Eklenme Tarihi")]
        public DateTime eklenmeTarih { get; set; }

        public int goruntulenme { get; set; }
        public int begeni { get; set; }
        
    }
}