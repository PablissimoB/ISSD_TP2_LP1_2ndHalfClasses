using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMateria
    {
        public static List<Materia> Get ()
        {
            try
            {
                return DMateria.GetAll ();
            }
            catch (Exception) {
                throw;
            }
        }
        public static void Delete(int id)
        {
            try
            {
                DMateria.DeleteMateria(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(int id, string descripcion)
        {
            try
            {
                DMateria.UpdateMateria(id, descripcion);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Insert(string descripcion)
        {
            try
            {
                DMateria.InsertMateria(descripcion);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
