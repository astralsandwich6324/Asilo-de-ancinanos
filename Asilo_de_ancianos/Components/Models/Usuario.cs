using System.ComponentModel.DataAnnotations;

namespace Asilo_de_ancianos.Components.Models
{
    public class Usuario
    {
        
        public int Id { get; set; }
        [Required] public string? Nombre { get; set; }

        [Required] public string? Apellido { get; set; }


        [Required] public int Edad { get; set; }

        public string? Correo { get; set; }

        [Required] public string? Telefono { get; set; }

        public string? Foto { get; set; } 

    }
}
