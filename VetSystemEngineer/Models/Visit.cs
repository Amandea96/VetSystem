using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetSystemEngineer.Models
{
    public partial class Visit
    {
       

        [Key]
        [Column("id_visit")]
        public int IdVisit { get; set; }
        [Column("id_patient")]
        public int IdPatient { get; set; }
        [Column("dateVisit", TypeName = "datetime2(7)")]
        public DateTime DateVisit { get; set; }
        [Required]
        [Column("purpose")]
       
        public string Purpose { get; set; }
        [Required]
        [Column("decrDisActions")]
        
        public string DecrDisActions { get; set; }
        [Column("id_vet")]
        public string Id { get; set; }

        [ForeignKey(nameof(IdPatient))]
        [InverseProperty(nameof(Patient.Visit))]
        public virtual Patient IdPatientNavigation { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(ApplicationUser.Visit))]
        public virtual ApplicationUser IdNavigation { get; set; }
       
    }
}
