using System;
using POO_Abs_Tecnologia;

namespace POO_Abs_Tecnologia{
    class Principal{
        public static void Main(string[] args){

            Laptop lap1 = new Laptop(16,"GTX 1650","SSD 500","TITO");    
            
            lap1.Caracteristicas();

            Celular cel1 = new Celular("Entel","iPhone","Tito","XR");

            cel1.Caracteristicas();

            Tablet tab1 = new Tablet(11,64,"Tito","Pad 5");

            tab1.Caracteristicas();

        }
    }
}
