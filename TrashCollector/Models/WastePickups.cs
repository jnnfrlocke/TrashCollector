using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class WastePickups
    {
        [Key]
        public int Id { get; set; }
        
        public ApplicationUser Customer { get; set; }
        public int CustomerID { get; set; }

        [Display(Name = "Collection Day")]
        public string CollectionDay { get; set; }

        public string Begin { get; set; }

        public string End { get; set; }

        [Display(Name = "Collection Dates")]
        public string CollectionDates { get; set; }

        [Display(Name ="Cost per Pickup")]
        public int CostPerPickup { get; set; }

        public int Balance { get; set; }
    }
}