using System;

namespace EjercicioTicket{
    public class Linea
    {
        private short unidades;
        private double pUnidad;
        private double pTotal;
        private Producto producto;
        
        public Linea():this(0,0.0,0.0,new Producto()){
        }
        
        public Linea(short unidades,double pUnidad,double pTotal,Producto producto){
            this.unidades=unidades;
            this.pUnidad=pUnidad;
            this.pTotal=pTotal;
            this.producto=producto;
        }

        public double getPUnidad() {
            return this.pUnidad;
        }

        public void setPUnidad(double pUnidad) {
            this.pUnidad = pUnidad;
        }

        public double getPTotal() {
            return this.pTotal;
        }

        public void setPTotal(double pTotal) {
            this.pTotal = pTotal;
        }             

        public Producto getProducto() {
            return this.producto;
        }

        public void setProducto(Producto producto) {
            this.producto = producto;
        } 
        
    }
}