namespace Figura
{
    public class Triangulo : Forma
    {
        private double b;
        private double h;
        private double lado1;
        private double lado2;
        public Triangulo(double b, double h, double lado1, double lado2) 
            :base(b + lado1 + lado2, (b * h) / 2)
        {
            this.setB(b);
            this.setH(h);
            this.setLado1(lado1);
            this.setLado2(lado2);
        }

        public double getB()
        {
            return this.b;
        }

        public void setB(double b)
        {
            this.b = b;
        }


        public double getH()
        {
            return this.h;
        }

        public void setH(double h)
        {
            this.h = h;
        }

        public double getLado1()
        {
            return this.lado1;
        }

        public void setLado1(double lado1)
        {
            this.lado1 = lado1;
        }

        public double getLado2()
        {
            return this.lado2;
        }

        public void setLado2(double lado2)
        {
            this.lado2 = lado2;
        }

        public override string ToString(){
            return string.Format("Soy un triángulo de base {0}, altura {1}, lado1 {2}, lado2 {3}, perimetro {4} y area {5}",
            this.getB(),this.getH(),this.getLado1(),this.getLado2(),base.getPerimetro(),base.getArea());
        }
        
        public override void dibujar(){ 
            string espacio=" ";     
            string barra="";
            System.Console.WriteLine(" /\\");  
            for(int i=1;i<(int)this.getH();i++){
                espacio=" ";     
                for(int j=0;j<i;j++){
                    espacio+=" ";
                    barra+="_";
                }
                System.Console.WriteLine("/" + espacio + "\\");  
            }       
            System.Console.WriteLine("/" + barra + "\\"); 
        }
    }
}