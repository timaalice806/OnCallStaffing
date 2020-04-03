using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnCall_Staffing.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Name { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}