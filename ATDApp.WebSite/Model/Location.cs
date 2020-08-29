using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATDApp.WebSite.Model
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        public String LocationName { get; set; }

        public String Intersection { get; set; }

        public String Address { get; set; }
        
        public String City { get; set; }

        [Required]
        public Double Zip { get; set; }

        public Double CouncilDistrict { get; set; }

        //public Byte[] SSMA_TimeStamp { get; set; }

    }
}
