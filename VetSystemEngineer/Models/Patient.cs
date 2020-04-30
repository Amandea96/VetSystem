using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetSystemEngineer.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Visit = new HashSet<Visit>();
            PatientInstitution = new HashSet<PatientInstitution>();
        }

        [Key]
        [Column("id_patient")]
        public int IdPatient { get; set; }
        [Column("id_owner")]
        public string Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("age", TypeName = "date")]
        
        public DateTime Age { get; set; }

        

       
        [Column("weight")]
        public double? Weight { get; set; }
        [Column("breed")]
        [StringLength(50)]
        public string Breed { get; set; }
        [Required]
        [Column("sex")]
        [StringLength(50)]
        public string Sex { get; set; }

        [Column("id_genus")]
        public int IdGenus { get; set; }


        [Column("sterilized_castration")]
        public string SterilizedCastration { get; set; }

        

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(ApplicationUser.Patient))]
        public virtual ApplicationUser IdNavigation { get; set; }
        [InverseProperty("IdPatientNavigation")]
  public virtual ICollection<Visit> Visit { get; set; }
        public virtual ICollection<PatientInstitution> PatientInstitution { get; set; }

        [ForeignKey(nameof(IdGenus))]
        [InverseProperty(nameof(Genus.Patient))]
        public virtual Genus IdGenusNavigation { get; set; }
    }
}
