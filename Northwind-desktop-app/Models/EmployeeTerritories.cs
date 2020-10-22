using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind_desktop_app.Models
{
    class EmployeeTerritories
    {
        [Key, Column(Order = 0)]
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employees Employee { get; set; }

        [Key, Column(Order = 1)]
        public string TerritoryID { get; set; }
        [ForeignKey("TerritoryID")]
        public Territories Territory { get; set; }

    }
}
