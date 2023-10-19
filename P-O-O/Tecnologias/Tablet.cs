using System;
//using POO_Abs_Tecnologia;

namespace POO_Abs_Tecnologia{
    class Tablet : Abs_Computadoras{
        //Atributos
        private int pulgadas;
        private int gb;
        

        //Constructores
        public Tablet(int pulgadas,int gb,string dueño,string modelo):base(dueño,modelo){
            this.pulgadas = pulgadas;
            this.gb = gb;
        }

        //Métodos
        public void Caracteristicas(){
            Console.WriteLine("\nLas caracteristicas del Tablet son : \nDueño: "+getDueño()+"\nModelo: "+getModelo()+"\nPulgadas: "+this.pulgadas+"\nAlmacenamiento: "+this.gb);
        }


    }
}
