using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.ViewModels
{
    public class ShowInstitution
    {

        public Institution Inst { get; set; }
        public List <ApplicationUser> Employees { get; set; }
    }
}
