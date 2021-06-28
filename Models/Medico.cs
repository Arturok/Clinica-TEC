using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Health_Tec.Models
{
    public class Medico
    {
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        public int Cedula { get; set; }
        [Required][StringLength(50)]
        public string Nombre { get; set; }
        [Required][StringLength(50)]
        public string Apellido1 { get; set; }
        [Required][StringLength(50)]
        public string Apellido2 { get; set; }
        [Required][StringLength(50)]
        public string Especialidad { get; set; }
        [Required]
        public bool Estado { get; set; }
        public ICollection<Clinica> Clinicas { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
        public Medico()
        {
            Clinicas = new Collection<Clinica>();
            Pacientes = new Collection<Paciente>();
        }
    }
    
}