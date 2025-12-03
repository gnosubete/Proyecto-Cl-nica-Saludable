using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_de_salud.Modelos
    {
        public class Usuario
        {
            public int Id { get; set; }
            public string Rut {  get; set; }
            public string Nombre { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Rol { get; set; }
        }
    }
