namespace Figura
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado):base(lado,lado){
        }

        public override sealed string ToString(){
            return string.Format("Soy un cuadrado de lado: {0}",base.getB()) + ". " + base.ToString();
        }
    }
}