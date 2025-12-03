using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_de_salud
{
    public class HoraDisponible
    {
        public int Id { get; set; }
        public int Medico_Id { get; set; }
        public string MedicoNombre { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        // Propiedad para mostrar en el grid
        public string HoraFormateada
        {
            get { return Hora.ToString(@"hh\:mm"); }
        }
    }
}
