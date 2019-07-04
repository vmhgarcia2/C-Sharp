namespace EjercicioOrdenador
{
    public class Ram
    {
        private byte tamanyo;
        private byte[] numCeldas;

        public Ram() : this(0)
        {
        }

        public Ram(byte tamanyo)
        {
            this.setTamanyo(tamanyo);
            this.numCeldas = new byte[tamanyo];
        }

        public byte getTamanyo()
        {
            return this.tamanyo;
        }

        public void setTamanyo(byte tamanyo)
        {
            this.tamanyo = tamanyo;
        }
    }
}