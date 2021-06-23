using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Health_Tec.Models
{
    public class Telefono
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }
    }
}