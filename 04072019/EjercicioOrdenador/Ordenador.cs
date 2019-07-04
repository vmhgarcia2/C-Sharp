namespace EjercicioOrdenador
{
    public class Ordenador
    {
        private Ram memoria;
        private Procesador procesador;
        private string modelo;
        private Almacenamiento almacenamiento;

        public Ordenador(Ram memoria,Procesador procesador,string modelo,Almacenamiento almacenamiento){
            
        }
        public Ram getMemoria()
        {
            return this.memoria;
        }

        public void setMemoria(Ram memoria)
        {
            this.memoria = memoria;
        }

        public Procesador getProcesador()
        {
            return this.procesador;
        }

        public void setProcesador(Procesador procesador)
        {
            this.procesador = procesador;
        }

        public string getModelo()
        {
            return this.modelo;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public Almacenamiento getAlmacenamiento()
        {
            return this.almacenamiento;
        }

        public void setAlmacenamiento(Almacenamiento almacenamiento)
        {
            this.almacenamiento = almacenamiento;
        }

    }
}