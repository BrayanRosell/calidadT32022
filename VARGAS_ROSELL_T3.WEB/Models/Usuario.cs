using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VARGAS_ROSELL_T3.WEB.Models
{
    public class Usuario
    {
        public int IdUsuario  { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Direccion { get; set; }
        [Required]
        public String Telefono { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail no es válido")]
        public String Email { get; set; }
        [Required]
        public String Username { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(8)]
        public String Password { get; set; }
        //
        public List<Animal> Animales { get; set; }
    }
}
