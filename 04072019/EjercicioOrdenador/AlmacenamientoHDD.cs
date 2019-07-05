namespace EjercicioOrdenador
{
    public class AlmacenamientoHDD : Almacenamiento
    {
        public AlmacenamientoHDD(byte capacidad, short velocidadEscritura, short velocidadLectura):
        base(capacidad, velocidadEscritura, velocidadLectura)
        {
            
        }
    }
}