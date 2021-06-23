using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Health_Tec.Controllers.Presentation
{
    public class PacienteResourceLite
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Otros { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoSangre { get; set; }
        public EstadoResource Estado { get; set; }     
        public ICollection<TelefonoResource> Telefonos { get; set; }   
        public PacienteResourceLite()
        {
            Telefonos = new Collection<TelefonoResource>();
        }
    }
}