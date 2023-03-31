using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class estados_equipo
    {
        [Key]
        public int id_estados_equipo { get; set; }
        [Display(Name = "Descripción")]
        public string? descripcion { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
