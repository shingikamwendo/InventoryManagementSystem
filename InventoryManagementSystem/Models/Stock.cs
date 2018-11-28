using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public class Stock
    { 
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Please input the product name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Please input the quantity")]
        [Display(Name="Quantity")]
        public int Quantity { get; set; }
        
        [Display(Name = "Upload Image")]
        public string ImageUrl { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
        [Required(ErrorMessage = "Please input the user")]
        [Display(Name = "Added By")]
        public string AddedBy { get; set; }
        [Required(ErrorMessage = "Please select status")]
        [Display(Name = "Status")]
        public string IsActive { get; set; } 


        public virtual List<Order> Orders { get; set; }
        public virtual List<Purchase> Purchases { get; set; }
    }
}