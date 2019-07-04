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

            Ticket miTicket=new Ticket(DateTime.Today,"ElSuper");
            miTicket.nuevaLinea(2,champu);
            miTicket.nuevaLinea(2,pan);
            miTicket.nuevaLinea(3,manzana);
            miTicket.nuevaLinea(6,cafe);
            miTicket.nuevaLinea(2,nesquick); 

            string s="_";

            System.Console.WriteLine(new string('_',45));
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
