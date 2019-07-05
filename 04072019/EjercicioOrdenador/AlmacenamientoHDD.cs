namespace EjercicioOrdenador
{
    public class AlmacenamientoHDD:Almacenamiento
    {
        public AlmacenamientoHDD():this(0,50,100){
        }

        public AlmacenamientoHDD(byte capacidad,short velocidadEscritura,short velocidadLectura){
            this.setCapacidad(capacidad);
            this.setVelocidadEscritura(velocidadEscritura);
            this.setVelocidadLectura(velocidadLectura);            
        }
    }
}