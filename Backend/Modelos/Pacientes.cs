using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_de_salud.Modelos
{
    public class Pacientes
    {
        public int id { get; set; }
        public string nombre_completo { get; set; }
        public string rut { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string sexo_genero { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string sistema_salud { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
