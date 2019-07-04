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
    
        public Ticket():this(DateTime.Today,""){
        }

        public Ticket(DateTime fecha,string nombreSuper){
            this.setFecha(fecha);
            this.setNombreSuper(nombreSuper);
            linea=new Linea[10];
            for(int i=0;i<this.linea.Length;i++){
                this.linea[i]=new Linea();
            }
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
        public int primeraLineaVacia(){
            for(int i=0;i<this.linea.Length;i++){
                if(this.linea[i].getUnidades()==0){
                    return i;
                }
            }
            return 100;
        }

        public void nuevaLinea(short c,Producto p){
            int a=this.primeraLineaVacia();
            this.linea[a]=new Linea(c,p);
            totalCompra+=linea[a].getprecioTotal();
        }
    }
}