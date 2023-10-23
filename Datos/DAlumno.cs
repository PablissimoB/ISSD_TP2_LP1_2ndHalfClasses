using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAlumno
    {
        public static List<Alumno> GetAll()
        {
            var result = new List<Alumno>(); //declaracion implicita
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllAlumnos", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Alumno estudiante = new Alumno();
                        estudiante.id = Convert.ToInt32(reader["id"]);
                    estudiante.nombre = reader["nombre"].ToString();
                        estudiante.apellido = reader["apellido"].ToString();
                    result.Add(estudiante);
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public static void InsertAlumno(string nombre, string apellido)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("InsertAlumno", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
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
