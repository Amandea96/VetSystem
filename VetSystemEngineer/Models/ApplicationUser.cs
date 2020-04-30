using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace VetSystemEngineer.Models
{
    public partial class ApplicationUser : IdentityUser
    {
        
       
    
    public ApplicationUser()
    {
        Patient = new HashSet<Patient>();
        Visit = new HashSet<Visit>();
    }

        /*[Key]
        [Column("id_vet")]
        public int IdVet { get; set; }
        [Required]
        [Column("pass")]
        [StringLength(10)]
        public string Passw { get; set; }
        [Required]
        [Column("name_vet")]
        [StringLength(50)]
        public string NameVet { get; set; }*/

        [Required(ErrorMessage = "Proszę podaj imię")]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("surname")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Column("id_inst")]
        public int? IdInst { get; set; }
        [Column("address")]
        public string Address { get; set; }
        
        [Column("education")]
        [StringLength(50)]
        public string Education { get; set; }


        [Required]
        [NotMapped]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [ForeignKey(nameof(IdInst))]
        [InverseProperty(nameof(Institution.ApplicationUser))]
        public virtual Institution IdInstNavigation { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ICollection<Patient> Patient { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ICollection<Visit> Visit { get; set; }



    }
}
