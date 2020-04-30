using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.ViewModels
{
    public class JoinPatientOwner
    {
        public Patient Pet { get; set; }
        public ApplicationUser Owner { get; set; }

        public PatientInstitution PaInst { get; set; }

        public Genus TypePet { get; set; }
    }
}
