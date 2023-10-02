using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DInscripcion
    {
        private int id { get; set; }
        private int idEstudiante { get; set; }
        private int idCategoria { get; set;}

        DInscripcion(int id, int idEstudiante, int idCategoria)
        {
            this.id = id;
            this.idEstudiante = idEstudiante;
            this.idCategoria = idCategoria;
        }
    }
}
