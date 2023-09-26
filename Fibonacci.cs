using System;

namespace Fibonacci{
    class Program{
        static void Main(string[] args){
            
            int num = 0;

            Console.Write("Ingrese número de términos de la serie : ");
            num = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;

            Console.Write("Serie de Fibonacci : ");

            for(int i = 1 ; i <= num ; i++){
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }

        }
    }
}
