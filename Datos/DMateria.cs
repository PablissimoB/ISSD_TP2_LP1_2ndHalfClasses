namespace Datos
{
    public class DMateria
    {
        private int id {  get; set; }
        private string descripcion { get; set; }
        
        DMateria(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
    }
}