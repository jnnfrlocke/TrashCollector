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

        //[Display(Name = "CollectionDay")]
        //public string CollectionDay { get; set; }

        public ApplicationUser Customer { get; set; }
        public string CustomerID { get; set; }

        [Display(Name = "Street Number")]
        public int StreetNumber { get; set; }

        [Display(Name = "Street Name")]
        public string StreetName { get; set; }

        public string Apartment { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string Zip { get; set; }

        [Display(Name = "Collection Day")]
        public string CollectionDay { get; set; }

        [Display(Name = "Vacation Hold Begins")]
        public string Begin { get; set; }

        [Display(Name = "Vacation Hold Ends")]
        public string End { get; set; }

        [Display(Name = "Collection Dates")]
        public string CollectionDates { get; set; }

        [Display(Name ="Cost per Pickup")]
        public int CostPerPickup { get; set; }

        public int Balance { get; set; }
    }
}