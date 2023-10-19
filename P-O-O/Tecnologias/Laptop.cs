using System;
//using POO_Abs_Tecnologia;


namespace POO_Abs_Tecnologia{
    class Laptop : Abs_Computadoras{
        //Atributos
        private int ram;
        private string grafica;
        private string memoria;

        public Laptop(int ram, string grafica, string memoria, string dueño):base(dueño){
            this.ram = ram;
            this.grafica = grafica;
            this.memoria = memoria;
        }

        //Métodos
        public void Caracteristicas(){
            Console.WriteLine("\nLas características de la Laptop son : \nDueño : "+ getDueño() +"\nRam : "+ this.ram +"\nGráfica : "+ this.grafica +"\nMemoria : "+ this.memoria);
        }

    }
}
