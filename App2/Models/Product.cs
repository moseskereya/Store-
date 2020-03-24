using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App2.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string Name { get; set; }
        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string description { get; set; }
        public string ImageUrl { get; set; }
        public string ShortDescription { get; set; }
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int? CategotyId { get; set; }
        public virtual Colors Color { get; set; }
        public int? AccesoriesId { get; set; }
        public Accesories Accesories { get; set; }
        public virtual Categoty Categoty { get; set; }
    }
}