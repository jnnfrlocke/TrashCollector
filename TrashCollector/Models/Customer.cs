using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public ApplicationUser UserId { get; set; }

        //[Display(Name = "First Name")]
        //public string FirstName { get; set; }

        //[Display(Name = "Last Name")]
        //public string LastName { get; set; }

        //[Display(Name ="Email Address")]
        //[EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        //public string EmailAddress { get; set; }

        //[Display(Name ="Street Number")]
        //public int StreetNumber { get; set; }

        //[Display(Name ="Street Name")]
        //public string StreetName { get; set; }

        //public string Apartment { get; set; }
        
        //public string City { get; set; }

        //public string State { get; set; }

        //[Display(Name = "Zip Code")]
        //public int ZipCode { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Collection Day")]
        public string CollectionDay { get; set; }

        [Display(Name = "Collection Dates")]
        public int CollectionDates { get; set; }

        [Display(Name = "Cost per Pickup")]
        public int CostPerPickup { get; set; }

        public int Balance { get; set; }
    }
}