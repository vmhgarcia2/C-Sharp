namespace EjercicioOrdenador
{
    public class Almacenamiento
    {
        private byte capacidad;
        private short velocidadLectura;
        private short velocidadEscritura;

        public Almacenamiento():this(0,0,0){
            
        }

        public Almacenamiento(byte capacidad,short velocidadEscritura,short velocidadLectura){
            this.capacidad=capacidad;
            this.setVelocidadLectura(velocidadLectura);
            this.setVelocidadEscritura(velocidadEscritura);
        }

        public byte getCapacidad()
        {
            return this.capacidad;
        }

        public void setCapacidad(byte capacidad)
        {
            this.capacidad= capacidad;
        }

        public short getVelocidadLectura()
        {
            return this.velocidadLectura;
        }

        public void setVelocidadLectura(short velocidadLectura)
        {
            this.velocidadLectura= velocidadLectura;
        }
        public short getVelocidadEscritura()
        {
            return this.velocidadEscritura;
        }

        public void setVelocidadEscritura(short velocidadEscritura)
        {
            this.velocidadEscritura= velocidadEscritura;
        }
    }
}