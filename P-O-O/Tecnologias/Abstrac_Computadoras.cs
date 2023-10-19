using System;
using POO_Abs_Tecnologia;

namespace POO_Abs_Tecnologia{
    abstract class Abs_Computadoras{
        //Atributos Abstractos
        private string dueño ;
        private string modelo ;
        private int peso ; 

        //Constructor
        public Abs_Computadoras(string dueño){
            this.dueño = dueño;
        }
        public Abs_Computadoras(int peso){
            this.peso = peso;
        }
        public Abs_Computadoras(string dueño, string modelo){
            this.dueño = dueño;
            this.modelo = modelo;
        }

        public Abs_Computadoras(string dueño, string modelo, int peso){
            this.dueño = dueño;
            this.modelo = modelo;
            this.peso = peso;
        }

        //Métodos Abstractos
        public void setDueño(string dueño){
            this.dueño = dueño;
        }

        public string getDueño(){
            return this.dueño;
        }

        public void setModelo(string modelo){
            this.modelo = modelo;
        }

        public string getModelo(){
            return this.modelo;
        }

        public void setPeso(int peso){
            this.peso = peso;
        }

        public int getPeso(){
            return this.peso;
        }

    }
}
