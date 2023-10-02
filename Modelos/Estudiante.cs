namespace Modelos
{
    public class Estudiante
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cuil { get; set; }

        public Estudiante(int id, string nombre, string apellido, string cuil)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuil = cuil;
        }
    }
}