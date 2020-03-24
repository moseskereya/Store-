using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App2.Models
{
    public class Colors
    {
        [Key]
        public int ColorId { get; set; }
        public string Name { get; set; }
        public bool availability { get; set; }
        public virtual ICollection<Categoty> Categoties { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}