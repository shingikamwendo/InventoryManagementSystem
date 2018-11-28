using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models 
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please input customer name")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage="Please input address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please input phone number")]
        [Display(Name = "Phone Number")]
        public string CellNo { get; set; }
        [Required(ErrorMessage = "Please input user")]
        public string AddedBy { get; set; }
        
        [Required(ErrorMessage = "Please select order")]
        
        public int OrderId { get; set; }

        public virtual List<Order> Orders { get; set; }


    }
}