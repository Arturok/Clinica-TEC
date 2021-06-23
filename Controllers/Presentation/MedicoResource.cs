using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Health_Tec.Controllers.Presentation
{
    public class MedicoResource
    {
        public string Id { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Especialidad { get; set; }
        public bool Estado { get; set; }
        public ICollection<ClinicaResourceLite> Clinicas { get; set; }
        public ICollection<PacienteResourceLite> Pacientes { get; set; }
        public MedicoResource()
        {
            Clinicas = new Collection<ClinicaResourceLite>();
            Pacientes = new Collection<PacienteResourceLite>();
        }
        
    }
}