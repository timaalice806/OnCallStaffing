using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall_Staffing.Models
{
    public class Posting
    {
        public int PostingID { get; set; }

        [Display(Name = "Position Title")]
        [Required]
        public string PositionTitle { get; set; }

        [Required]
        public string Facility { get; set; }

        [Display(Name = "Date & Time")]
        [Required]
        public DateTime DateTime { get; set; }

        [Display(Name = "Pay Rate")]
        [Required]
        public string PayRate { get; set; }

        [Display(Name = "Position Description")]
        [Required]
        public string PositionDescription { get; set; }

        [Display(Name = "Arrival Instructions")]
        [Required]
        public string ArrivalInstructions { get; set; }

        [Display(Name = "Address")]
        [ForeignKey("AddressID")]
        public int AddressID { get; set; }
        public Address Address { get; set; }
        [NotMapped]
        public IEnumerable<Address> Addresses { get; set; }

        [Display(Name = "Employer")]
        [ForeignKey("EmployerID")]
        public int EmployerID { get; set; }
        public Employer Employer { get; set; }
        [NotMapped]
        public IEnumerable<Employer> Employers { get; set; }
        public ICollection<PostingEmployeeJoin> PostingEmployeeJoins { get; set; }
    }
}
