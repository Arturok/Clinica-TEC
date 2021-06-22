using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Health_Tec.Models
{
    public class Clinica
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Dirección { get; set; }
        public int Teléfono { get; set; }
        public string Correo { get; set; }
        public string SitioWeb { get; set; }
        public ICollection<Medico> Medicos { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }

        public Clinica()
        {
            Medicos = new Collection<Medico>();
            Pacientes = new Collection<Paciente>();
        }

    }
}