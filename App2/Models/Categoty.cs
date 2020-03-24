using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App2.Models
{
    public class Categoty
    {
        [ScaffoldColumn(false)]
        [Key]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}