using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models 
{
    public class Employee
    {
        [Display(Name = "ID")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please input employee name")]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Please input email address")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Please enter a valid email")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please input phone number")]
        [Display(Name = "Phone Number")]
        public string CellNo { get; set; }
        [Required(ErrorMessage = "Please input address")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please input salary")]
        [Display(Name = "Salary")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "Please input user")]
        [Display(Name = "Added By")]
        public string AddedBy { get; set; }
        [Required(ErrorMessage = "Please select status")]
        [Display(Name = "Status")]
        public string IsActive { get; set; }
    
    }
}