using VideojuegosApi.Models;
using System.Collections.Generic;

namespace VideojuegosApi.utils
{
    public class Almacen
    {        
        private readonly static Almacen _instance = new Almacen();
        public List<VideojuegosItem> bibliotecaVideojuegos = new List<VideojuegosItem>();

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