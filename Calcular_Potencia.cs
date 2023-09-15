using System;

namespace Expontente{
    class Program{
        static void Main(string[] args){
            double num = 0;
            double exp = 0;
            double res = 1;

            Console.Write("Ingrese Base : ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese Exponente : ");
            exp = Convert.ToDouble(Console.ReadLine());

            if(exp == 0){
                Console.WriteLine("Resultado : 1");
            }else if(exp == 1){
                Console.WriteLine("Resultado : " + num );
            }else{
                for(int i = 1 ; i <= exp ; i++){
                    Console.WriteLine($"{num} elevado a {i} = {res}");
                    res *= num;
                }Console.WriteLine("Rsultado Final = " + res);
            }
        }
    }
}
