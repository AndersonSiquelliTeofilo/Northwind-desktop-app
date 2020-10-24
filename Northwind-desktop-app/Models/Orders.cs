using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind_desktop_app.Models
{
    class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customers Customers { get; set; }
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employees Employees { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; } // ShipVia
        [ForeignKey("ShipVia")]
        public Shippers Shippers { get; set; }
        public double Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }
}
