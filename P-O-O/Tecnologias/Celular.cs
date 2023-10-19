using System;
//using POO_Abs_Tecnologia;

namespace POO_Abs_Tecnologia{
    class Celular : Abs_Computadoras{
        //Atributos

        private string chip ;
        private string marca ;


        //Constructores
        public Celular(string chip, string marca,string dueño,string modelo):base(dueño, modelo){
            this.chip = chip;
            this.marca = marca;
        }

        //Métodos
        public void Caracteristicas(){
            Console.WriteLine("\nLas características del Celular son : \nDueño: "+getDueño()+"\nChip: "+this.chip+"\nMarca: "+this.marca+"\nModelo: "+getModelo());
        }

    }
}
