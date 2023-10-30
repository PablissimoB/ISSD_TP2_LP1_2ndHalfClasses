using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NInscripcion
    {
        public static List<Inscripcion> Get()
        {
            try
            {

                return DInscripcion.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Insert(int idMateria, int idAlumno, int turno, DateTime fechaInscripcion)
        {
            try
            {
                DInscripcion.InsertInscripcion(idMateria, idAlumno, turno, fechaInscripcion);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
