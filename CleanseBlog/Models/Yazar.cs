using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CleanseBlog.Models
{
    public class Yazar
    {
        public int id { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string mail { get; set; }
        public DateTime kayitTarih { get; set; }
        public string nick { get; set; }

      
    }
}