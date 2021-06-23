using System.ComponentModel.DataAnnotations;

namespace Health_Tec.Models
{
    public class Estado
    {
        public int Id { get; set; }
        [Required][StringLength(50)]
        public string Nombre { get; set; }
    }
}