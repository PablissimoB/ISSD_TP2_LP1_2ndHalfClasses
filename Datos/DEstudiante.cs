using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstudiante
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string cuil { get; set; }

        DEstudiante(int id, string nombre, string apellido, string cuil)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuil = cuil;
        }
    }
}
