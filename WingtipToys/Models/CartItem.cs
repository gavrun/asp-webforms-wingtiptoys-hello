using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WingtipToys.Models
{
    public class CartItem
    {
        // Key attribute overrides primary key
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; } // not primary key
        public int Quantity { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int ProductId { get; set; }

        // Navigation property
        public virtual Product Product { get; set; }
    }
}