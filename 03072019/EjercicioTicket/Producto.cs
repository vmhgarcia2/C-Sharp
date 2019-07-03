namespace EjercicioTicket
{
    public class Producto
    {
        private string nombre;
        private double peso;
        private double precio;

        public Producto(): this("",0.0,0.0){
        }

        public Producto(string nombre,double precio,double peso){
            this.setNombre(nombre);
            this.setPrecio(precio);
            this.setPeso(peso);
        }

        public string getNombre() {
            return this.nombre;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }       

        public double getPrecio() {
            return this.precio;
        }

        public void setPrecio(double precio) {
            this.precio = precio;
        }
        public double getPeso() {
            return this.precio;
        }

        public void setPeso(double precio) {
            this.precio = precio;
        }
    }
}