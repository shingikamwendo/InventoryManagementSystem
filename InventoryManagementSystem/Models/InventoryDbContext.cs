using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class InventoryDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}