using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


//Connections with DB tables and entities
namespace DataAccess.Concrete.EntityFramework {
    public class BytePazariContext:DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BytePazariDB;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cpu> Cpu { get; set; }
        public DbSet<Gpu> Gpu { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Ram> Ram { get; set; }
        public DbSet<Storage> Storage { get; set; }


    }
}
