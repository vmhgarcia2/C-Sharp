using System;

namespace EjercicioTicket{
    public class Linea
    {
        private short unidades;
        private double precioUnidad;
        private double precioTotal;
        private Producto producto;
        
        public Linea():this(0,new Producto()){
        }
        
        public Linea(short unidades,Producto producto){
            this.unidades=unidades;
            this.precioUnidad=producto.getPrecio();
            this.precioTotal=(unidades*precioUnidad);
            this.producto=producto;
        }

        public double getprecioUnidad() {
            return this.precioUnidad;
        }

        public void setprecioUnidad(double precioUnidad) {
            this.precioUnidad = precioUnidad;
        }         
        public double getprecioTotal() {
            return this.precioTotal;
        }

        public void setprecioTotal(double precioTotal) {
            this.precioTotal = precioTotal;
        }             

        public Producto getProducto() {
            return this.producto;
        }

        public void setProducto(Producto producto) {
            this.producto = producto;
        } 
        
        public short getUnidades() {
            return this.unidades;
        }

        public void setUnidades(short unidades) {
            this.unidades = unidades;
        } 
        
    }
}