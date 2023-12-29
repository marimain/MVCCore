using System;
using System.Collections.Generic;
namespace MVCCore.Models
{
    public class PatientMetricsViewModel
    {
        public PatientMetricsViewModel()
        {

        }
        public IEnumerable<PatientDetail> Patients { get; set; }


    }
}
