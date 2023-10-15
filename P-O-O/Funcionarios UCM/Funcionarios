using System;

namespace POO_Funcionarios{
    class Funcionario{
        //Atributos
        private string nombre = "Sin nombre";
        private int añosServio;
        private string titulo = "Sin titulo";

        //Constructores
        public Funcionario(){

        }
        public Funcionario(string nombre){
            this.nombre = nombre;
            Console.WriteLine("Se ha instanciado el funcionario : " + this.nombre);
        }
        public Funcionario(string nombre, string titulo,int añosServio){
            this.nombre = nombre;
            this.titulo = titulo;
            this.añosServio = añosServio;

            Console.WriteLine("Se ha instanaciado funcionario con mucha informacion");

        }
        //Métodos
        public void colar(){
            Console.WriteLine("El funcionario "+ this.nombre + " dice : ñam ñam ñam");
        }
        public void irReunion(){
            Console.WriteLine("El funcionario " + this.nombre + "se encuentra en reunión");
        }
        public string getNombre(){
            return this.nombre;
        }
    }   
}
