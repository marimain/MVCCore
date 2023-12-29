using System;
using System.Collections.Generic;

namespace MVCCore.Models
{
    public class PatientDetail
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
    }
}
