using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Health_Tec.Models
{
    public class Paciente
    {
        [StringLength(50)]
        public string Id { get; set; }
        [Required][StringLength(50)]
        public string Nombre { get; set; }
        [Required][StringLength(50)]
        public string Apellido1 { get; set; }
        [Required][StringLength(50)]
        public string Apellido2 { get; set; }
        [Required][StringLength(50)]
        public string Provincia { get; set; }
        [Required][StringLength(50)]
        public string Canton { get; set; }
        [Required][StringLength(50)]
        public string Distrito { get; set; }
        [StringLength(50)]
        public string Otros { get; set; }
        [Required][StringLength(50)]
        public string Correo { get; set; }
        [Required][DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)][DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [Required][StringLength(50)]
        public string TipoSangre { get; set; }
        [Required]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public ICollection<Telefono> Telefonos { get; set; }
        public ICollection<Clinica> Clinicas { get; set; }
        public ICollection<Medico> Medicos { get; set; }
        public Paciente()
        {
            Telefonos = new Collection<Telefono>();
            Clinicas = new Collection<Clinica>();
            Medicos = new Collection<Medico>();
        }

    }
}