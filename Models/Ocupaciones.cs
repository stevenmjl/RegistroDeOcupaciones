using System.ComponentModel.DataAnnotations;

namespace RegistroDeOcupaciones.Models
{
    public class Ocupaciones
    {
        [Key]
        public int OcupacionId { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        public string? Descripcion { get; set; }

        [Range(minimum:11500, maximum:1000000,ErrorMessage ="Debe estar entre 11,500 y 1,000,000")]
        public float Salario { get; set; }
    }
}
