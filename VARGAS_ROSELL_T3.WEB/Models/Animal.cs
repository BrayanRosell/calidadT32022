using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VARGAS_ROSELL_T3.WEB.Models
{
    public class Animal
    {
        public int Id { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public String Tamanio { get; set; }
        public String DatosParticulares { get; set; }
        public int IdUsuario { get; set; }
        public int IdSexo { get; set; }
        public int IdEspecie { get; set; }
        public int IdRaza { get; set; }
        //
        public Usuario Usuarios { get; set; }
        public Raza Razas { get; set; }
        public Especie Especies { get; set; }
        public Sexo Sexos { get; set; }
    }
}
