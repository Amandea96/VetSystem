using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VetSystemEngineer.ViewModels
{
    public class CreatePatientVisit
    {
        public List<SelectListItem> ListType { get; set; }
        [Required (ErrorMessage = "Proszę wybierz typ/rodzaj zwierzęcia")]
        public int SelectedType { get; set; }


        //Owner
        [Required (ErrorMessage ="Proszę podaj adres email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podaj hasło")]
        [StringLength(100, ErrorMessage = "Hasło musi składać się z choć: jednej dużej, małej litery, cyfry oraz znaku specjalnego", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Hasło nie jest takie samo")]
        public string ConfirmPassword { get; set; }

        public string SterilizedCastration { set; get; }
        public List<SelectListItem> SterilizedCastrationList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "brak", Text = "brak" },
            new SelectListItem { Value = "kastrowany", Text = "kastrowany" },
            new SelectListItem { Value = "kastrowana", Text = "kastrowana"  },
            new SelectListItem { Value = "sterylizowana", Text = "sterylizowana"  },
            new SelectListItem { Value = "sterylizowany", Text = "sterylizowany"  },
        };

        [Required(ErrorMessage = "Proszę podaj nazwisko")]
        [RegularExpression(@"^[a-zA-Z-ąćęłńśóźżĆŁŚŻŹŃ-]+$", ErrorMessage = "Proszę użyj tylko liter")]
        [Display(Name = "Surname")]
        [StringLength(50)]
        public string Surname { get; set; }


        public int? IdInst { get; set; }


        public string Address { get; set; }



        [Required(ErrorMessage = "Proszę podaj imię")]
        [RegularExpression(@"^[a-zA-Z-ąćęłńśóźżĆŁŚŻŹŃ]+$", ErrorMessage = "Proszę użyj tylko liter")]
        public string NameOwner { get; set; }

        public string PhoneNumber { get; set; }

        
        
        //Visit
       // public int IdVisit { get; set; }
        
        //public int IdPatient { get; set; }
        
         [Required(ErrorMessage = "Proszę podaj powód wizyty")]
        
        [StringLength(200)]
        public string Purpose { get; set; }
        [Required(ErrorMessage = "Proszę podaj opis czynności")]
        
        [StringLength(8000)]
        public string DecrDisActions { get; set; }
        
        //public string Id { get; set; }


        //Patient
       // public int IdPatient { get; set; }
        
        //public string Id { get; set; }
        [Required(ErrorMessage = "Proszę podaj imię zwierzęcia")]
        
        [StringLength(50)]
        public string NamePet { get; set; }
        
        [DataType(DataType.Date)]
       
        public DateTime Age { get; set; }
        
        public double? Weight { get; set; }
        [Required (ErrorMessage = "Proszę podaj rasę" )]
        [StringLength(50)]
        public string Breed { get; set; }


        [StringLength(50)]
        public string Type { get; set; }
        [Required]
        
        [StringLength(50)]
        public string Sex { get; set; }
    }
}
