using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace G20240408.EntidadesDeNegocio
{
    public class PersonaG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required (ErrorMessage ="EL campo Nombre es requerido")]
        [StringLength(60)]
        [Display(Name ="Nombre")]
        
        public string NombreG { get; set; }

        [Required(ErrorMessage = "EL campo Apellido es requerido")]
        [StringLength(60)]
        [Display(Name = "Apellido")]
        public string ApellidoG { get; set; }
        
        [Display(Name = "Fecha Nacimiento")]
        [Required(ErrorMessage = "EL campo Fecha es requerido")]
        public DateTime FechaNacimientoG { get; set; }

        [Required(ErrorMessage = "EL campo Sueldo es requerido")]
        [Display(Name = "Sueldo")]
        public Decimal SueldoG { get; set; }
        [Required(ErrorMessage = "EL campo Estatus es requerido")]
        [Display(Name = "Estatus")]
        public byte  EstatusG { get; set; }


    }
}
