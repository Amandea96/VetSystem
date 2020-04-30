using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.ViewModels
{
    public class Pets
    {
        //dodanie dostępu do dokumentacji

        //public AddPetToInst PetAndInst { get; set; }
        public List<SelectListItem> ListInst { get; set; }
        public int SelectedInst { get; set; }

        public List<SelectListItem> ListNamePet { get; set; }
        public int SelectedPet { get; set; }
      


        //jakie placówki mają dostęp do dokumentacji
        public List <PetsBelongsToInst> DocInInst { get; set; }



        //lista zwierząt właściciela
        public List<Patient> PetsList { get; set; }
       
    }
}
