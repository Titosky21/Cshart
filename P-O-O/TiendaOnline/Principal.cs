using System;
//debe usarse el nombre del "namespace"
using Productos;

namespace TiendaOnline{
    class Program{
        static void Main(string[] args){
            //instanciar un objeto
            Producto producto1 = new Producto(101, "Notebook HP", 800000, 10); //como se creo el constructor con parametros este tambien debe tener parametros
            Producto producto2 = new Producto(202, "SmartPhone", 500000, 15);

            //utilizacion de los objetos
            producto1.getInfo();
            producto2.getInfo();

            Console.WriteLine("\nCompras: ");
            producto1.comprar(2); //compramos 2 notebook
            producto2.comprar(8); //compramos 2 SmartPhone

            producto1.getInfo();
            producto2.getInfo();

            //metodos y constructor que pidio el profe del lab

            Producto producto3 = new Producto();

            producto3.setPrecio(200);
            producto3.setNombre("Lenovo");

            Console.WriteLine($"Nombre del Producto 3 : {producto3.getNombre()} y el Precio es : {producto3.getPrecio()}");

        }
    }
}
