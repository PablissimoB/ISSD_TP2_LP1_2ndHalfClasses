using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DInscripcion
    {
        public static List<Inscripcion> GetAll()
        {
            List<Inscripcion> result = new List<Inscripcion>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllInscripciones", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Materia materia = DMateria.GetById(Convert.ToInt32(reader["idMateria"]));
                    Alumno alumno = DAlumno.GetById(Convert.ToInt32(reader["idAlumno"]));
                    var inscripcion = new Inscripcion(
                        Convert.ToInt32(reader["id"]), 
                        alumno,
                        materia, 
                        (DateTime)(reader["fechaInscripcion"]), 
                        Convert.ToInt32(reader["turno"]) );
                    result.Add(inscripcion);
                }

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }


        public static void InsertInscripcion(int idMateria, int idAlumno, int turno, DateTime fechaInscripcion)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("InsertInscripcion", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idMateria", idMateria);
                command.Parameters.AddWithValue("@idAlumno", idAlumno);
                command.Parameters.AddWithValue("@turno", turno);
                command.Parameters.AddWithValue("@fechaInscripcion", fechaInscripcion);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
