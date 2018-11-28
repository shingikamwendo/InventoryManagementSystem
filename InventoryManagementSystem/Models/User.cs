using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace InventoryManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please input user name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please input the password")]
        //[StringLength(20, MinimumLength = 6, ErrorMessage = "Password should be 6 to 20 character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Please input role name")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        //[Required(ErrorMessage = "Please select the employee")]
        [Display(Name = "Employee Name")]      
        public int EmployeeId { get; set; }
        //[Required(ErrorMessage = "Please select status")]
        [Display(Name = "Status")]
        public string IsActive { get; set; }

        public virtual Employee Employee { get; set; }
    }
}