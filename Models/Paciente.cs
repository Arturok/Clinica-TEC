using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Health_Tec.Models
{
    public class Paciente
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public ICollection<int> Telefonos { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string FechaNacimiento { get; set; }
        public string TipoSangre { get; set; }
        public ICollection<Clinica> Clinicas { get; set; }
        public string Estado { get; set; }
        public Clinica Clinica { get; set; }
        public string ClinicaId { get; set; }

        public Paciente()
        {
            Clinicas = new Collection<Clinica>();
        }

    }
}