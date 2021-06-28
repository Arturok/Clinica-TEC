using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Health_Tec.Models
{
    public class Clinica
    {
        [StringLength(50)]
        public string Id { get; set; }
        [Required][StringLength(50)]
        public string Nombre { get; set; }
        [Required][StringLength(50)]
        public string Provincia { get; set; }
        [Required][StringLength(50)]
        public string Canton { get; set; }
        [Required][StringLength(50)]
        public string Distrito { get; set; }
        [Required][StringLength(50)]
        public string Otros { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required][StringLength(50)]
        public string Correo { get; set; }
        [Required][StringLength(50)]
        public string SitioWeb { get; set; }
        [Required][StringLength(50)]
        public string DiaInicio { get; set; }
        [Required][StringLength(50)]
        public string DiaFinal { get; set; }
        [Required][StringLength(50)]
        public string HoraInicio { get; set; }
        [Required][StringLength(50)]
        public string HoraCierre { get; set; }
        public ICollection<Medico> Medicos { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }

        public Clinica()
        {
            Medicos = new Collection<Medico>();
            Pacientes = new Collection<Paciente>();
        }

    }
}