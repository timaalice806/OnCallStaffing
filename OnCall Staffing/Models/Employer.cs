using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall_Staffing.Models
{
    public class Employer
    {
        [Key]
        public int EmployerID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public EmailAddressAttribute EmailAddress { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public PhoneAttribute PhoneNumber { get; set; }

        [ForeignKey]
    }
}
