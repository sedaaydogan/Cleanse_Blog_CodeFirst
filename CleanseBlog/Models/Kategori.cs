using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CleanseBlog.Models
{
    public class Kategori
    {
        public int id { get; set; }
        [StringLength(50)]
        public string adi { get; set; }

        public virtual  List<Makale> Makales { get; set; }
    }
}