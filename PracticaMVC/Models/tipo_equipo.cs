using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class tipo_equipo
    {
        [Key]
        public int id_tipo_equipo { get; set; }
        [Display(Name = "Descripción")]
        public string? descripcion { get; set; }
        [Display(Name = "Estado")]
        public string Estado { get; set; }
    }
}
