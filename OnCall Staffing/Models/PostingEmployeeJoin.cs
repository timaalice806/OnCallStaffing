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
        public int PostingID { get; set; }
        public Posting Posting { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        //public bool Hired { get; set; }

    }
}
