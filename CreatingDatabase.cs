using Microsoft.EntityFrameworkCore;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Data
{
    public class CreatingDatabase : DbContext
    {
        public CreatingDatabase(DbContextOptions<CreatingDatabase> options) : base(options)
        {


        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmployeeTerritories> EmployeeTerritories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Territories> Territories { get; set; }
        public object Region { get; internal set; }
    }
}
