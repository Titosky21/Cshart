using System;

namespace NumerosPositivos{
    class Program{
        static void Main(string[] args){
            string str = "";

            Console.Write("ingrese numero : ");
            str = Console.ReadLine();

            int num = Convert.ToInt32(str);

            if(num < 0){
                Console.WriteLine("Es un numero negativo");
                for (int i = 0 ; i < str.Length ; i++){
                
                    Console.WriteLine($"{i+1} Digitos."); 
                }
            }else{
                for (int i = 0 ; i < str.Length ; i++){
                
                    Console.WriteLine($"{i+1} Digitos."); 
                }
            }
        }
    }
}
