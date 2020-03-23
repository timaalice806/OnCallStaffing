using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall_Staffing.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        public EmailAddressAttribute EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        public PhoneAttribute PhoneNumber { get; set; }

        [Required]
        public string Certifications { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
