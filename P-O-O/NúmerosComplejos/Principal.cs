using System;
using POO_Complejos;

namespace POO_Complejos{
    class Principal{
        public static void Main(string[] args){

            Complejo numC1 = new Complejo(-4,5);
            numC1.sumaComplejos(2,1);
            numC1.restaComplejos(1,2);
            numC1.multiplicacionComplejos(3,5);
            numC1.divisionCompleja(8,2);
        }
    }
}
