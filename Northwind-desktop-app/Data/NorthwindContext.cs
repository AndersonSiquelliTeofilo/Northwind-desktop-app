using System;
using System.Data.Entity;
using Northwind_desktop_app.Models;

namespace Northwind_desktop_app.Data
{
    class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("Northwind")
        {
        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmployeeTerritories> EmployeeTerritories { get; set; }
        public DbSet<Territories> Territories { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public DbSet<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
    }
}

