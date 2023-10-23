using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlumno
    {
        public static List<Alumno> Get()
        {
            try
            {
                return DAlumno.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Insert(string nombre, string apellido)
        {
            try
            {
                DAlumno.InsertAlumno(nombre, apellido);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}