using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Dto
{
    public class MuestrasDto
    {
        public int Id { get; set; }
        public string Persona_Muestrada { get; set; }
        public Nullable<System.DateTime> Fecha_Toma { get; set; }
        public string Persona_Toma_Muestra { get; set; }
    }
}
