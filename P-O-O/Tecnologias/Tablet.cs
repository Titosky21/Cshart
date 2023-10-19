using System;
//using POO_Abs_Tecnologia;

namespace POO_Abs_Tecnologia{
    class Tablet : Abs_Computadoras{
        //Atributos
        private int pulgadas;
        private int gb;
        private string marca;

        //Constructores
        public Tablet(int pulgadas,int gb,string marca,string dueño,string modelo):base(dueño,modelo){
            this.pulgadas = pulgadas;
            this.gb = gb;
            this.marca = marca;
        }

        //Métodos
        public void Caracteristicas(){
            Console.WriteLine("\nLas caracteristicas del Tablet son : \nDueño: "+getDueño()+"\nMarca: "+this.marca+"\nModelo: "+getModelo()+"\nPulgadas: "+this.pulgadas+"\nAlmacenamiento: "+this.gb);
        }


    }
}
