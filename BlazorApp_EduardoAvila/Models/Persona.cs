namespace BlazorApp_EduardoAvila.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string ApellidoPaterno { get; set; } = "";
        public string ApellidoMaterno { get; set; } = "";
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; } = "";
    }
}
