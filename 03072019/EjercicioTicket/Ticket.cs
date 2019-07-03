using System;
//Un ticket de la compra tiene: 
//fecha, nombre del supermercado, 
//total compra y lineas del ticket (máximo 10)
namespace EjercicioTicket
{
    public class Ticket
    {
        private DateTime fecha;  
        private string nombreSuper;
        private double totalCompra;
        private Linea[] linea;     
    
        public Ticket():this(DateTime.Today,"",0.0,new Linea[10]){
        }

        public Ticket(DateTime fecha,string nombreSuper,double totalCompra,Linea[] linea){
            this.setFecha(fecha);
            this.setNombreSuper(nombreSuper);
            this.setTotalCompra(totalCompra);
            this.setLinea(linea);
        }

        public DateTime getFecha() {
            return this.fecha;
        }

        public void setFecha(DateTime fecha) {
            this.fecha = fecha;
        }
        
        public string getNombreSuper() {
            return this.nombreSuper;
        }

        public void setNombreSuper(string nombreSuper) {
            this.nombreSuper = nombreSuper;
        }

        public double getTotalCompra() {
            return this.totalCompra;
        }

        public void setTotalCompra(double totalCompra) {
            this.totalCompra = totalCompra;
        }

        public Linea[] getLinea() {
            return this.linea;
        }

        public void setLinea(Linea[] linea) {
            this.linea = linea;
        }

    }

}