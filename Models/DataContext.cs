using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace SuperMarket.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("SuperMarket")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public System.Data.Entity.DbSet<SuperMarket.Models.New> News { get; set; }
    }
}