using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public class Supplier 
    {
        [Key]
        public int SuppliersId { get; set; }
        [Required(ErrorMessage = "Please input the product name")]
        [Display(Name = "Supplier Name")]
        public string SuppliersName { get; set; }
        [Required(ErrorMessage = "Please input phone number")]
        [Display(Name = "Phone Number")]
        public string CellNo { get; set; }
        [Required(ErrorMessage = "Please input the Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please input the user")]
        [Display(Name = "Added By")]
        public string AddedBy { get; set; }
        [Required(ErrorMessage = "Please select status")]
        [Display(Name = "Status")]
        public string IsActive { get; set; }

       
        public virtual List<Purchase> Purchases { get; set; }
    }
}