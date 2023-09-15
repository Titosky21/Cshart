using System;

namespace Calculadora{
    class Program{
        static void Main(string[] args){
            Console.Write("Ingrese el Primer Numero: ");
            double  num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el Segundo Numero: ");
            double  num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write(" 1-Suma \n 2-Resta \n 3-Multiplicacion \n 4-Division \nIngrese numero de la Operación que desea: ");
            double  opcion = Convert.ToDouble(Console.ReadLine());
            double  resultado = 0 ;
            
            switch(opcion){
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("La operación seleccionada es: Suma");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("La operación seleccionada es: Resta");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("La operación seleccionada es: Multiplicacion");
                    break;
                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine("La operación seleccionada es: Division");
                    break;
                default:
                    Console.WriteLine("###--Opcion no valida--###");
                    break;
            }

            Console.WriteLine("El Resultado es: " + resultado);
        }
    }
}

