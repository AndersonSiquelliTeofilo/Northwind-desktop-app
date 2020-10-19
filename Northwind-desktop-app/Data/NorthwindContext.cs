using System;
using System.Data.Entity;

namespace Northwind_desktop_app.Data
{
    class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("Northwind")
        {
        }
    }
}
