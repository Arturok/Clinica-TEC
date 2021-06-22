namespace Health_Tec.Models
{
    public class Medico
    {
        public string Id { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Especialidad { get; set; }
        public bool Estado { get; set; }
        public Clinica Clinica { get; set; }
        public string ClinicaId { get; set; }

    }
}