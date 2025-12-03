using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_de_salud.Modelos
{
    public class Citas
    {
        public int id { get; set; }
        public int paciente_id { get; set; }
        public int medico_id { get; set; }
        public string especialidad { get; set; }
        public DateTime fecha_hora { get; set; }
        public string estado { get; set; }
        public int creado_por { get; set; }
        public DateTime fecha_creacion { get; set; }
        public string medio_solicitud { get; set; }
    }
}
