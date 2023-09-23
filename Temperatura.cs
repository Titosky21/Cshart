using System;

namespace Temperatura{

    class Program{

        static void Main(string[] args){
            
            double res = 0.0 ;

            Console.WriteLine("Convertidor de Celsius a Fahrenheit");

            Console.Write("Convertir de Temperatura \n 1)Celsius a Fahrenheit \r\n 2)Fahrenheit a Celsius \n Ingrese Opcion : ");
            int op = Convert.ToInt32(Console.ReadLine());

            if(op == 1){
                Console.Write("Ingrese le Temperatura en Celsius : ");
                double C = Convert.ToDouble(Console.ReadLine());

                res = ( C * 9/5 ) + 32 ;

                Console.WriteLine("La Temperatura en Fahrenheit : " + res.ToString("0.##"));
            }else{
                Console.Write("Ingrese le Temperatura en Fahrenheit : ");
                double F = Convert.ToDouble(Console.ReadLine());

                res = ( F - 32 ) * 5/9 ;

                Console.WriteLine("La Temperatura en Celsius : " + res.ToString("0.##"));//el comando "ToString("0.##"); " es para imprimir decimales. 
            }
        }
    }
}
