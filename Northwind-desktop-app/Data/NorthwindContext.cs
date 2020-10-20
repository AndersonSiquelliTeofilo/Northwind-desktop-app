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
    }
}
