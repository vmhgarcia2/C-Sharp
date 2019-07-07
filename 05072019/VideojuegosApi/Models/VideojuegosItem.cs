namespace VideojuegosApi.Models
{
    public class VideojuegosItem
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public int anyoLanzamiento { get; set; }
        public GenerosItem genero { get; set; }
        public byte edadMinima { get; set; }
        public string companyia { get; set; }
    }
}