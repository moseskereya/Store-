using System;
using System.Collections.Generic;
using System.Linq;
using App2.Models;
using System.Data.Entity;
using System.Web;

namespace App2.Models
{
    public class App2DBContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Categoty> categoties { get; set; }
        public DbSet<Colors> colors { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Accesories> Accesories { get; set; }



    }
}