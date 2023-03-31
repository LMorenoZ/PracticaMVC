using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class carreras
    {
        [Key]
        public int carrera_id { get; set; }
        [Display(Name = "Carrera")]
        public string? nombre_carrera { get; set; }
        [Display(Name = "Id Facultad")]
        public int facultad_id { get; set; }    
    }
}
