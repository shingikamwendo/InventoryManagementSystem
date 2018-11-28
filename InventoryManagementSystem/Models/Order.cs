using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } 
        [Required(ErrorMessage="Please input order date")]
        [Display(Name="Order Date")]
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Please select the product")]
        [Display(Name = "Product Name")]
        //[ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please select the customer")]
        [Display(Name = "Coutomer Name")]
       // [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please input user")]
        [Display(Name = "Added By")]
        public string AddedBy { get; set; }
        [Required(ErrorMessage = "Please input order quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Please input price")]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Stock Stock { get; set; }
    }
}