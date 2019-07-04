namespace Figura
{
    public class Rectangulo : Forma
    {
        private double b;
        private double h;

        public Rectangulo(double b, double h) : base(b * 2 + h * 2, b * h)
        {
            this.setB(b);
            this.setH(h);
        }

        public double getH()
        {
            return this.h;
        }

        public void setH(double h)
        {
            this.h = h;
        }


        public double getB()
        {
            return this.b;
        }

        public void setB(double b)
        {
            this.b = b;
        }

        public override string ToString(){
            return string.Format("Soy un rectángulo de base {0}, altura {1}, perímetro {2} y area {3}",
            this.b,this.h,base.getPerimetro(),base.getArea());
        }

        public override void dibujar(){
            string car="";
            for(int i=0;i<getH();i++){
                for(int j=0;j<getB();j++){
                    car+="*";
                }
                System.Console.WriteLine(car);
                car="";
            }
        }
    }
}