namespace Figura
{
    //De una clase abstracta no puedes crear una instancia
    public abstract class Forma
    {
        private double perimetro;
        private double area;

        public Forma()
        {

        }
        public Forma(double perimetro, double area)
        {
            this.setPerimetro(perimetro);
            this.setArea(area);
        }

        public double getPerimetro()
        {
            return this.perimetro;
        }

        public void setPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }

        public double getArea()
        {
            return this.area;
        }

        public void setArea(double area)
        {
            this.area = area;
        }

        //Sobreescrible el método por defecto de la clase object
        public override string ToString(){
            return string.Format("Soy una forma de perimetro {0} y area {1}",this.perimetro,this.area);
        }   

        //metodo abstracto, no lleva llaves
        public abstract void dibujar();
    }
}