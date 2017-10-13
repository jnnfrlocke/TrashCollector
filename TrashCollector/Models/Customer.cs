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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string EmailAddress { get; set; }

        public int StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string PhoneNumber { get; set; }

        public string CollectionDay { get; set; }

        public int CollectionDates { get; set; }

        public int CostPerPickup { get; set; }

        public int Balance { get; set; }

        [CreditCard(ErrorMessage = "Please enter a valid credit card number.")] // Make this secure?
        public int? CreditCard { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM}", ApplyFormatInEditMode = true )]
        public object ExpDate { get; set; }




    }
}