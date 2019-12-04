using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    public class Paciente
    {
        public int ID { get; set; }
        public string NumSeguridadSocial { get; set; }
        public string CI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
