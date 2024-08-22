namespace WebApplication1.Controllers
{
    public class Persona
    {
        public string nombre;
        public string ciudadd;
        public int edad;

        public Persona()
        {
        }

        public Persona(string nombre, string ciudadd, int edad)
        {
            this.nombre = nombre;
            this.ciudadd = ciudadd;
            this.edad = edad;
        }
    }
}
