using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.ViewModels
{
    public class MedicalDocumentation
    {
        public List<SelectListItem> ListType { get; set; }
        [Required(ErrorMessage = "Proszę wybierz typ zwierzęcia")]
        public int SelectedType { get; set; }
        public Genus PetType { get; set; }

        public string SterilizedCastration { set; get; }
        public List<SelectListItem> SterilizedCastrationList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "brak", Text = "brak" },
            new SelectListItem { Value = "kastrowany", Text = "kastrowany" },
            new SelectListItem { Value = "kastrowana", Text = "kastrowana"  },
            new SelectListItem { Value = "sterylizowana", Text = "sterylizowana"  },
            new SelectListItem { Value = "sterylizowany", Text = "sterylizowany"  },
        };
        public Patient Pet { get; set; }
        public ApplicationUser Owner { get; set; }  
        public List<Visit> medicalHistory { get; set; }
        public List<ApplicationUser> VetInfo { get; set; }

        public double? Weight { get; set; }
      

        [Required(ErrorMessage = "Proszę podaj powód wizyty")]
         public string Purpose { get; set; }
        [Required(ErrorMessage = "Proszę podaj wykonane czynności")]
         public string DecrDisActions { get; set; }

    }
}
