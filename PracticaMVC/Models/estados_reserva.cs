using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class estados_reserva
    {
        [Key]
        public int estado_res_id { get; set; }
        [Display(Name = "Estado")]
        public string? Estado { get; set; }
    }
}
