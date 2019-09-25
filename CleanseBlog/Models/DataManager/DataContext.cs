using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CleanseBlog.Models.DataManager
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DatabaseContext")
        {

        }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<Resim> Resims { get; set; }
        public DbSet<Etiket> Etikets { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }

    }
}