using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.ViewModels
{
    public class PetsBelongsToInst
    {

        public int PetID { get; set; }
        public string NamePet { get; set; }
        public List <Institution> Insts { get; set; }
        

    }
}
