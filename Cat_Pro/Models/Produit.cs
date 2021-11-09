using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cat_Pro.Models
{
    public class Produit
    {
       [Display(Name ="Produit ID")]
       [Key]
        public int ProduitID { get; set; }
        [Required]
        [MinLength(6), MaxLength(20)]
        public string Description { get; set; }
        [Required]
        [Range(100,5000)]
        public double Prix { get; set; }
    }
}
