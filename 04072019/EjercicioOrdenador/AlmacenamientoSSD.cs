namespace EjercicioOrdenador
{
    public class AlmacenamientoSSD:Almacenamiento
    {
        public AlmacenamientoSSD():this(0,200,500){
        }

        public AlmacenamientoSSD(byte capacidad,short velocidadEscritura,short velocidadLectura){
            this.setCapacidad(capacidad);
            this.setVelocidadEscritura(velocidadEscritura);
            this.setVelocidadLectura(velocidadLectura);            
        }
    }
}