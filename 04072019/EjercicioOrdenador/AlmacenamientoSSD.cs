namespace EjercicioOrdenador
{
    public class AlmacenamientoSSD:Almacenamiento
    {
        public AlmacenamientoSSD(byte capacidad, short velocidadEscritura, short velocidadLectura):
            base(capacidad, velocidadEscritura, velocidadLectura)
        {
            
        }
    }
}