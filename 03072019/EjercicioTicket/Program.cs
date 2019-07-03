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
            Producto champu=new Producto("Champu",2.0,150);
            Producto pan=new Producto("Pan",1.0,125);
            Producto manzana=new Producto("Manzana",1.0,30);
            Producto cafe=new Producto("Café",1.0,300);
            Producto nesquick=new Producto("Nesquick",5.0,300);

            Linea linea1=new Linea(2,champu);
            Linea linea2=new Linea(2,pan);
            Linea linea3=new Linea(3,manzana);
            Linea linea4=new Linea(6,cafe);
            Linea linea5=new Linea(2,nesquick); 
            Linea linea6=new Linea();
            Linea[] todasLineas={linea1,linea2,linea3,linea4,linea5,linea6,linea6,linea6,linea6,linea6};

            //Metodo añadir elemento al ticket
            Ticket miTicket=new Ticket(DateTime.Today,"ElSuper");
            miTicket.nuevaLinea(linea1);
            miTicket.nuevaLinea(linea2);
            miTicket.nuevaLinea(linea3);
            miTicket.nuevaLinea(linea4);
            miTicket.nuevaLinea(linea5);
            string s="_";

            System.Console.WriteLine(s.PadRight(45,'_'));
            System.Console.WriteLine(Convert.ToString("| Fecha: " + miTicket.getFecha()).PadRight(45,' ') + "|");
            System.Console.WriteLine(Convert.ToString("| Nombre: " + miTicket.getNombreSuper()).PadRight(45,' ') + "|");
            System.Console.WriteLine("|".PadRight(45,'-') + "|");
            System.Console.WriteLine(Convert.ToString(("| Producto".PadRight(12,' ') + " Unidades".PadRight(12,' ') + "Cantidad".PadRight(14,' ')+ "Precio").PadRight(45,' ') + "|"));
            System.Console.WriteLine("|".PadRight(45,'-') + "|");
            foreach(Linea l in miTicket.getLinea()){ 
                if(l.getUnidades()>0){             
                    System.Console.WriteLine(Convert.ToString("| " + l.getProducto().getNombre().PadRight(12,' ') + " " + Convert.ToString(l.getUnidades()).PadRight(14,' ') + Convert.ToString(l.getprecioUnidad()).PadRight(12,' ') + Convert.ToString(l.getprecioTotal()).PadRight(4,' ') + "|"));
                }
            }
            System.Console.WriteLine("|".PadRight(45,'-') + "|");
            System.Console.WriteLine(Convert.ToString("| Total de la compra: " + (Convert.ToString(miTicket.getTotalCompra()).PadLeft(21,' '))) + "  |");
            System.Console.WriteLine("|".PadRight(45,'_') + "|");
            
        }
    }
}
