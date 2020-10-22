using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind_desktop_app.Models
{
    class Territories
    {
        [Key]
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        [ForeignKey("RegionID")]
        public virtual Region Region { get; set; }
        public int RegionID { get; set; }
    }
}
