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
        Alumno alumno { get; set; }
        Materia materia { get; set; }
        public DateTime fecha { get; set; }
        public int turno { get; set; }

        public string? NombreMateria
        {
            get
            {
                if (materia != null)
                    return materia.descripcion;
                else
                    return null;
            }
        }
        public string? NombreCompletoAlumno
        {
            get
            {
                if (alumno != null)
                    return alumno.nombre +" " + alumno.apellido;
                else
                    return null;
            }          
        }
        public Inscripcion(int id, Alumno alumno, Materia materia, DateTime fecha, int turno)
        {
            this.id = id;
            this.alumno = alumno;
            this.materia = materia;
            this.fecha = fecha;
            this.turno = turno;
        }
    }
}
