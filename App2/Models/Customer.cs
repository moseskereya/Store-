using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int? CountryId { get; set; }
        [Display (Name = "Country Name")]
        public Country Country { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }

    public class Country
    {
        [Display(Name = "Country ID")]
        public int CountryId { get; set; }
        [Required]
        [Display(Name = "Country Name")]
        public string Name { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public string Code { get; set; }
        public List<Customer> customers { get; set; }
    }
}