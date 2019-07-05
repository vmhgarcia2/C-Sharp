namespace Videojuegos.Models
{
    public class Almacen
    {
        private readonly static Almacen _instance = new Almacen();
        public List<Videojuegos> bibliotecaVideojuegos = new List<Videojuegos>();

        public Almacen() { }

        public static Almacen Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}