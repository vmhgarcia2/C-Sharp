namespace EjercicioOrdenador
{
    public class Procesador
    {
        private double velocidad;
        private string modelo;

        public Procesador():this(0,""){

        }
        
        public Procesador(double velocidad,string modelo){
            this.setVelocidad(velocidad);
            this.setModelo(modelo);
        }
        
        public double getVelocidad()
        {
            return this.velocidad;
        }

        public void setVelocidad(double velocidad)
        {
            this.velocidad = velocidad;
        }

        public string getModelo()
        {
            return this.modelo;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

    }
}