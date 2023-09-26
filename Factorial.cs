using System;

namespace Factorial{
    class Program{

        static void calcularFac(int num){ //como se quiere retornar un entero, se utiliza el tipo "void"
            int var = 1;

            if(num == 0 || num == 1){
                Console.WriteLine("El Factorial es : 1");

            }else{
                for(int i = 1 ; i <= num ; i++){
                    var *= i ;
                    Console.WriteLine($"{i}! : {var}");
                }
            }
            //con el tipo "void" no es necesario el "return"
            Console.WriteLine($"El Factorial de {num}! : {var}");
        }

        static void Main(string[] args){
            int num = 0;
            //int var = 1;

            Console.Write("Ingrese Número : ");
            num = Convert.ToInt32(Console.ReadLine());
            
            //if(num == 0 ||num == 1){
            //     Console.WriteLine("El Factorial es : 1");

            // }else{
            //     for(int i = 1 ; i <= num ; i++){
            //         var *= i ;
            //         Console.WriteLine($"{i}! : {var}");
            //     }
            // }Console.WriteLine($"El Factorial de {num}! : {var}");

            calcularFac(num);

        }
    }
}
