namespace Modelos
{
    public class Alumno
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public Alumno(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Alumno() { }
    }
}