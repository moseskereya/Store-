using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App2.Models
{
    public class Accesories
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Amount { get; set; }
        public virtual List<Categoty> Categoties { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}