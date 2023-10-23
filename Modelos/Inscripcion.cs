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
        public DateOnly fecha { get; set; }
        public int turno { get; set; }

        Inscripcion(int id, int idEstudiante, int idCategoria, DateOnly fecha, int turno)
        {
            this.id = id;
            this.idEstudiante = idEstudiante;
            this.idCategoria = idCategoria;
            this.fecha = fecha;
            this.turno = turno;
        }
    }
}
