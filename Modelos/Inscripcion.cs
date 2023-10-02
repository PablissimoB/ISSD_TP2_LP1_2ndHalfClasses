using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Inscripcion
    {
        public int id { get; set; }
        public int idEstudiante { get; set; }
        public int idCategoria { get; set; }

        Inscripcion(int id, int idEstudiante, int idCategoria)
        {
            this.id = id;
            this.idEstudiante = idEstudiante;
            this.idCategoria = idCategoria;
        }
    }
}
