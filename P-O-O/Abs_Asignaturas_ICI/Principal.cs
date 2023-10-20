using System;
using POO_Asignaturas_ICI;

namespace POO_Asignaturas_ICI{
    class Principal{
        public static void Main(string[] args){
            

            string lenguaje,nombre,codigo;
            int creditos;

            Console.WriteLine("\nIngrese Nombre de la Carrera");
            nombre = Console.ReadLine();
            
            Console.WriteLine("\nIngrese lenguaje");
            lenguaje = Console.ReadLine();

            Console.WriteLine("\nIngrese código de la Carrera");
            codigo = Console.ReadLine();

            Console.WriteLine("\nIngrese créditos de la Carrera");

            creditos = Convert.ToInt32(Console.ReadLine());
            
            Programacion pro1 = new Programacion(lenguaje,nombre,codigo,creditos);

            pro1.areaDominio();//aquí si debe ir el método con los parentesis.       
        }
    }
}


