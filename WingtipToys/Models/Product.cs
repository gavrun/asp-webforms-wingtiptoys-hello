using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
    public class Product
    {
        // automatically generated UI-forms (scaffolded views), false means that the property will not be displayed
        [ScaffoldColumn(false)] 
        public int ProductID { get; set; } // Primary Key

        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)] 
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        // Navigation property
        public virtual Category Category { get; set; } // lazy loading
    }
}