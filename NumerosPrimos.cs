using System;

namespace NumerosPrimos{

    class Program{

        static bool esPrimo(int num){
            if ( num <= 1 ){
                return false;
            }
            for (int i = 2 ; i * i <= num ; i++ ){
                if(num % i == 0 ){
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args){
            
            int limite;

            Console.Write("Ingrese un numero para encontrar todos los primos hasta ese Limite : ");
            limite = Convert.ToInt32(Console.ReadLine()); 

            for ( int i = 2 ; i <= limite ; i++){
                bool booleano = esPrimo(i);
                    Console.WriteLine(i + " es primo : " + booleano);
                
            }

        }
    }
}
