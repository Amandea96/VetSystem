using System;
using System.Collections.Generic;

namespace VetSystemEngineer.Models
{
    public partial class PatientInstitution
    {
        public int IdPatient { get; set; }
        public int? IdInst { get; set; }

        public virtual Institution IdInstNavigation { get; set; }
        public virtual Patient IdPatientNavigation { get; set; }
    }
}
