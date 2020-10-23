using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind_desktop_app.Models
{
    class CustomerDemographics
    {
        [Key]
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    }
}
