using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Health_Tec.Controllers.Presentation
{
    public class ClinicaResource
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Otros { get; set; }
        public int Teléfono { get; set; }        
        public string Correo { get; set; }
        public string SitioWeb { get; set; }
        public string DiaInicio { get; set; }
        public string DiaFinal { get; set; }
        public string HoraInicio { get; set; }
        public string HoraCierre { get; set; }
        public ICollection<MedicoResourceLite> Medicos { get; set; }
        public ICollection<PacienteResourceLite> Pacientes { get; set; }
        public ClinicaResource()
        {
            Medicos = new Collection<MedicoResourceLite>();
            Pacientes = new Collection<PacienteResourceLite>();
        }
        
    }
}