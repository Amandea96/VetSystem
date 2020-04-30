using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VetSystemEngineer.ViewModels
{
    public class CreateBossVet
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        /*[Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use only letters")]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string UserName { get; set; }*/


        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use only letters")]
        [Display(Name = "Surname")]
        [StringLength(50)]
        public string Surname { get; set; }


        public int? IdInst { get; set; }


        public string Address { get; set; }

      
        [StringLength(50)]
        public string Education { get; set; }

        [Required]
        public string NameVet { get; set; }

        public string PhoneNumber { get; set; }
    }
}
