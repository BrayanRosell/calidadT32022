using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VARGAS_ROSELL_T3.WEB.Models
{
    public class Especie
    {
        public int IdEspecie { get; set; }
        public String Nombre { get; set; }
        //
        public List<Animal> Animales { get; set; }
    }
}
