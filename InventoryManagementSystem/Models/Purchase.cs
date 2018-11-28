using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{ 
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please input purchase date")]
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }
        [Required(ErrorMessage = "Please select product name")]
        [Display(Name = "Product Name")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please select quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Please input unit price")]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "Please input total price")]
        [Display(Name = "Total Price")]
        public decimal Total { get; set; }
        [Required(ErrorMessage = "Please select the supplier")]
        [Display(Name = "Supplier")]
       // [ForeignKey("SuppliersId")]
        public int SuppliersId { get; set; }
        [Required(ErrorMessage = "Please input the user")]
        [Display(Name = "added By")]
        public string AddedBy { get; set; }

        public virtual Stock Stock { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}