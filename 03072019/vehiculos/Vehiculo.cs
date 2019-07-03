using System;
using System.Reflection;

namespace Vehiculos
{
    public class Vehiculos
    {
        //Variables privadas -Solo desde dentro de la clase
        private byte numRuedas;
        private ushort numPasajeros;
        private string color; //Hexad, empieza por #
        private byte numPuertas;
        private bool esAutomatico;
        private bool encendido=false;
        private ushort vMax=0;
        private string[] combustible;
        private string bastidor;
        //Variables públicas
        public static byte numVolante=1;

        //constructor por defecto
        public Vehiculos() : this("rojo",4) {
        }
        public Vehiculos(string color,byte numRuedas=2){
            this.setColor(color);
            this.setNumRuedas(numRuedas);
        }
        
        //Método no estatico arrancar
        public void arrancar(){
            if(encendido){
                System.Console.WriteLine("El vehículo está arrancado");
            }
            else{
                encendido=true;                
                System.Console.WriteLine("Brruummm");
            }
        }
        
        //Métodos get y set
        public byte getNumRuedas() {
            return this.numRuedas;
        }

        public void setNumRuedas(byte numRuedas) {
            this.numRuedas = numRuedas;
        }

        public ushort getNumPasajeros() {
            return this.numPasajeros;
        }

        public void setNumPasajeros(ushort numPasajeros) {
            this.numPasajeros = numPasajeros;
        }

        public string getColor() {
            return this.color;
        }

        public void setColor(string color) {
            this.color = color;
        }            
        public byte getNumPuertas() {
            return this.numPuertas;
        }

        public void setNumPuertas(byte numPuertas) {
            this.numPuertas = numPuertas;
        }
            
        public bool getEsAutomatico() {
            return this.esAutomatico;
        }

        public void isEsAutomatico(bool esAutomatico) {
            this.esAutomatico = esAutomatico;
        }
        
        public ushort getVMax() {
            return this.vMax;
        }

        public void setVMax(ushort vMax) {
            this.vMax = vMax;
        }        

        public bool getEncendido() {
            return this.encendido;
        }

        public void isEncendido(bool encendido) {
            this.encendido = encendido;
        }

        private void setBastidor(){
            string p="ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string b="";
            Random r=new Random();
            int posicion=0;
            for(int i=0;i<17;i++){
                posicion=r.Next(0,p.Length);
                b+=p[posicion];
            }
            this.bastidor=b;
        }

        public bool compararNumBastidor(string bas){
            setBastidor();
            int i=string.Compare(bas,bastidor);
            return i==0?true:false;
        }      

        public string getbastidor(){
            return bastidor;
        }
    }
}