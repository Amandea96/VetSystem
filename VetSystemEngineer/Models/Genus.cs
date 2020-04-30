using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.Models
{
    public partial class Genus
    {
        public Genus()
        {
            Patient = new HashSet<Patient>();
        }
        [Key]
        [Column("id_genus")]
        public int IdGenus { get; set; }
        [Required (ErrorMessage ="Proszę podaj nazwę nowego typu/rodzaju zwierząt")]
        [Column("name_genus")]
        public string NameGenus { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
       
    }
}
