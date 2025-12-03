using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_de_salud.Modelos
{
    public class historial_paciente
    {
        public int id { get; set; }
        public int paciente_id { get; set; }
        public string motivo_consulta { get; set; }
        public string alergias { get; set; }
        public string medicamentos_actuales { get; set; }
        public string antecedentes_medicos { get; set; }
        public string antecedentes_familiares { get; set; }
        public DateTime fecha_ultima_consulta { get; set; }
        public string observaciones { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}