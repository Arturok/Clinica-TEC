using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Health_Tec.Controllers.Presentation
{
    public class MedicoResourceLite
    {
        public string Id { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Especialidad { get; set; }
        public bool Estado { get; set; }       
    }
}