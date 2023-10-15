using System;

namespace POO_Funcionarios{
    class Academico : Funcionario{
        //Atributos
        private string catAcad = "Sin categoria";

        //Constructores
        public Academico() : base(){

        }
        public Academico(string nombre):base(nombre){//le pasamos el parametro a base porque base sabe que hacer con este parametro
            Console.WriteLine("Se ha instanciado un academico");
            Console.WriteLine("El nombre del academico es : " + this.getNombre());
        }
        public Academico(string nombre, int añosServio, string categoria, string titulo) : base(nombre,titulo,añosServio){
            this.catAcad = categoria;
            Console.WriteLine("Se ha instanciado un academico con todo");
        }
        //Métodos
        public void investigar(){
            Console.WriteLine("Investigo");
        }

        public void docencia(){
            Console.WriteLine("docencia");
        }

        public void administrar(){
            Console.WriteLine("administrar");
        }

        public void vinculacion(){
            Console.WriteLine("vinculacion");
        }

    }
}
