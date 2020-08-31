using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATDApp.WebSite.Model
{
    public class Request
    {
        public int Field1 { get; set; }

        [Key]
        public int RequestId { get; set; }

        public int LocationID { get; set; }

        public DateTime RequestDate { get; set; }

        public String RequestType { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Phone { get; set; }

        [Required]
        public String Email { get; set; }

        public int NumberRacksRequested { get; set; }

        public int NumberRacksMarked { get; set; }

        public String Status { get; set; }

        public DateTime PreliminaryCheck { get; set; }

        public DateTime Marked { get; set; }

        public DateTime Fulfilled { get; set; }

        public DateTime DeniedRequest { get; set; }

        public String Comments { get; set; }

        public String Priority { get; set; }

        //public Byte[] SSMA_TimeStamp { get; set; }

        //test
    }
}
