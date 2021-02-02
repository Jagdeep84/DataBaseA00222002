using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Core;
using JagdeepDB.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace JagdeepDB.Contexts
{
   public class Context: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Region> Regions { get; set; }

        public Context(): this("DefaultConnection")
        {}
        public Context(string connName = "DefaultConnection"): base(connName)
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
