using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace VetSystemEngineer.Models
{
    public partial class Institution
    {
        public Institution()
        {
            ApplicationUser = new HashSet<ApplicationUser>();
            PatientInstitution = new HashSet<PatientInstitution>();
        }

        [Key]
        [Column("id_inst")]
        public int IdInst { get; set; }
        [Required(ErrorMessage = "Proszę podaj ulicę placówki")]
        [Column("address_inst")]
       
        [StringLength(100)]
        public string AddressInst { get; set; }
        [Required(ErrorMessage = "Proszę podaj miasto")]
        [Column("city")]
        [StringLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Proszę podaj kod pocztowy")]
        [Column("postcode")]
        [StringLength(10)]
        public string Postcode { get; set; }
        [Column("inter_list")]
       
        public string InterList { get; set; }
        [Required(ErrorMessage = "Proszę podaj nr tel placówki")]
        
        [Column("phNumInst")]
       
        [StringLength(10)]
        public string PhNumInst { get; set; }
        [Required(ErrorMessage = "Proszę podaj email placówki")]
        [EmailAddress]
        [Column("emailInst")]
        [StringLength(100)]
        public string EmailInst { get; set; }
        [Column("name_inst")]
        [StringLength(200)]
        [Required(ErrorMessage = "Proszę podaj nazwę placówki")]
        public string NameInst { get; set; }

        

        [InverseProperty("IdInstNavigation")]
        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
        public virtual ICollection<PatientInstitution> PatientInstitution { get; set; }
    }
}
