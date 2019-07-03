/* 
Crea un programa que represente la siguiente realidad, implementando las clases, 
métodos y propiedades que sean necesarios.
Un ticket de la compra tiene: fecha, nombre del supermercado, total compra y lineas del ticket (máximo 10).
Cada linea del ticket contiene, producto, precio por unidad, unidades y precio.
Del producto conocemos nombre, peso y precio.
Implementa en el método principal de la aplicación 5 productos, 
1 ticket con 5 lineas con diferentes cantidades y mostrar el ticket por pantalla.
 */
using System;

namespace EjercicioTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto champu=new Producto("Champu",2.35,150);
            Producto pan=new Producto("Pan",1.0,125);
            Producto manzana=new Producto("Manzana",0.35,30);
            Producto cafe=new Producto("Café",4.5,300);
            Producto nesquick=new Producto("Nesquick",5.5,300);

            short cantidadChampu=2;
            short cantidadpan=2;
            short cantidadmanzana=2;
            short cantidadcafe=2;
            short cantidadnesquick=2;


            Linea linea1=new Linea(cantidadChampu,champu.getPrecio(),(champu.getPrecio()*cantidadChampu),champu);
            Linea linea2=new Linea(cantidadpan,pan.getPrecio(),(pan.getPrecio()*cantidadpan),pan);
            Linea linea3=new Linea(cantidadmanzana,manzana.getPrecio(),(manzana.getPrecio()*cantidadmanzana),manzana);
            Linea linea4=new Linea(cantidadcafe,cafe.getPrecio(),(cafe.getPrecio()*cantidadcafe),cafe);
            Linea linea5=new Linea(cantidadnesquick,nesquick.getPrecio(),(nesquick.getPrecio()*cantidadnesquick),nesquick);
            Linea[] todasLineas=new Linea[5];
            //Metodo añadir elemento al ticket
            Ticket miTicket=new Ticket();
            
        }
    }
}
