using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class facultades
    {
        [Key]
        public int facultad_id { get; set; }
        [Display(Name = "Facultad")]
        public string? nombre_facultad { get; set; }
    }
}
