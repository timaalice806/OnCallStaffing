using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall_Staffing.Models
{
    public class PostingEmployeeJoin
    {
        [Key]
        public int JoinID { get; set; }

        [Display(Name = "Posting")]
        [ForeignKey("PostingID")]
        public int PostingID { get; set; }
        public Posting Posting { get; set; }
        public IEnumerable<Posting> Postings { get; set; }

        [Display(Name = "Employee")]
        [ForeignKey("EmployeeID")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        public bool Hired { get; set; }

    }
}
