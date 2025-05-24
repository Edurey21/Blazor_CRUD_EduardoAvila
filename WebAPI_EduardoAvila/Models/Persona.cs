using System.ComponentModel.DataAnnotations;

namespace WebAPI_EduardoAvila.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = "";

        [Required]
        public string ApellidoPaterno { get; set; } = "";

        public string ApellidoMaterno { get; set; } = "";

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [RegularExpression("^[MF]$", ErrorMessage = "El sexo debe ser 'M' o 'F'.")]
        public string Sexo { get; set; } = "";
    }
}
