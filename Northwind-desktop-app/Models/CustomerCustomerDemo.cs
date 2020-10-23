using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind_desktop_app.Models
{
    class CustomerCustomerDemo
    {
        [Key, Column(Order = 0)]
        public string CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customers Customers { get; set; }

        [Key, Column(Order = 1)]
        public string CustomerTypeID { get; set; }
        [ForeignKey("CustomerTypeID")]
        public CustomerDemographics CustomerDemographics { get; set; }
    }
}
