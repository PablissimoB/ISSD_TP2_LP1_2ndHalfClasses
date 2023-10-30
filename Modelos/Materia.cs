using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Materia
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public Materia(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
        public Materia() { }
    }
}
