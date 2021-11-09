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
        public int ProduitID { get; set; }
        [Required]
        [MinLength(6)]
        public string Description { get; set; }
        [Required]
        public double Prix { get; set; }
    }
}
