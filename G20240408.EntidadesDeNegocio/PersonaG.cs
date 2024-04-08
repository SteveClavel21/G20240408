using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace G20240408.EntidadesDeNegocio
{
    public class PersonaG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string NombreG { get; set; }

        [Required]
        [StringLength(60)]
        public string ApellidoG { get; set; }
        [Required]
        public DateTime FechaNacimientoG { get; set; }

        [Required]
        public Decimal SueldoG { get; set; }
        [Required]
        public byte  EstatusG { get; set; }


    }
}
