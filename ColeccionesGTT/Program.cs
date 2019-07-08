using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Pez:IEquatable<Pez>
    {
        private string color;
        private string nombre;

        /*
         * Dos formas distintas de declarar getters y setters
         */
        public string Color
        {
            get => color;
            set => color = value;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public bool Equals(Pez other)
        {
            return (this.color == other.color && this.nombre == other.nombre);
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Este es mi pez: " + this.Nombre + ", " + this.Color;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una lista de peces
            //List<string> peces = new List<string>{ "salmon", "merluza","besugo", "anguila"};
            //foreach(string pez in peces)
            //{
            //    Console.WriteLine(peces.IndexOf(pez)+1 + ": " + pez);
            //}
            //Console.WriteLine("-");
            //peces.Add("dorada");
            //peces.Remove("merluza");
            //foreach (string pez in peces)
            //{
            //    Console.WriteLine(peces.IndexOf(pez) + 1 + ": " + pez);
            //}
            //Console.WriteLine("-");
            //Console.WriteLine("Capacidad: " + peces.Capacity);
            //Console.WriteLine("Tamaño: " + peces.Count);
            //Console.WriteLine("Elemento 2 de la lista: " + peces[2]);

            /*
             * CREAMOS DOS INSTANCIAS DE LA CLASE PEZ, LOS AÑADIMOS A LA LISTA Y VEMOS SI MI LISTA CONTIENE UNA INSTANCIA EN CONCRETO
             */
            List<Pez> peces=new List<Pez>();
            Pez nemo = new Pez() { Nombre= "Nemo", Color ="naranja" };
            Pez dori = new Pez() { Nombre= "Dori", Color ="azul" };
            Pez dori2 = new Pez() { Nombre= "Besugo", Color ="amarillo" };
            peces.Add(nemo);
            peces.Add(dori);
            peces.Add(dori2);
            //foreach (Pez p in peces)
            //{
            //    Console.WriteLine(p.Nombre + " es de color " + p.Color);
            //}
            //Console.WriteLine("Mi lista de peces " + (peces.Contains(new Pez() { Nombre= "besugo", Color ="amarillo" }) ? "contiene a " : "no contiene a ") + dori2.nombre);

            //Console.WriteLine("");
            //Console.WriteLine("Borro el besugo");
            //Console.WriteLine("");
            //peces.Remove(new Pez() { Nombre= "besugo", Color ="amarillo" });
            //Console.WriteLine("Mi lista de peces " +  (peces.Contains(new Pez() { Nombre= "besugo", Color ="amarillo" })? "contiene a ":"no contiene a ") + dori2.nombre);
            
            //foreach(Pez p in peces)
            //{
            //    Console.WriteLine(p.Nombre + " es de color " + p.Color);
            //}

            
            List<string> cadenaPeces = new List<string> { "anguila", "besugo" };
            List<int> longitudPeces = cadenaPeces.ConvertAll<int>(p => p.Length);
            List<string> nombresPeces = peces.ConvertAll<string>(p => p.Nombre);

            Console.WriteLine("He creado una lista de nombres de peces con 'ConvertAll'");
            foreach (string p in nombresPeces)
            {
                Console.WriteLine(p);
            }

            //Diccionario<clave (única),tipo>
            Dictionary<string, Pez> diccionarioPeces = new Dictionary<string, Pez>();
            diccionarioPeces.Add("Nemo", nemo);
            try{
                diccionarioPeces.Add("Nemo", dori);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Estás intentando añadir un elemento con la misma clave");
            }
            diccionarioPeces.Add("Nemo2", nemo);

            foreach (var p in diccionarioPeces)
            {
                Console.WriteLine(p.Key);
                Console.WriteLine(p.Value.Nombre);
                Console.WriteLine(p.Value.Color);
            }

            Pez pezEncontrado;
            bool encontrado = diccionarioPeces.TryGetValue("Nemo2", out pezEncontrado);
            if (encontrado)
            {
                Console.WriteLine(pezEncontrado.ToString());
            }
        }
    }
}
