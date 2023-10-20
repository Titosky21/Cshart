using System;

namespace POO_Abs_Lista{
    class Pila : Lista {
        //Atributos
        private int[] array ; //creamos un arreglo

        //Constructor
        public Pila(int[] array){
            this.array = array;
        }

        //Métodos Abstractos heredados, se debe usar override
        public override void Primero(){
            int tam = this.array.Length;
            Console.WriteLine($"\nPrimer Elemento de la Pila: {this.array[tam - 1]}");
        }
        public override void Ultimo(){
            Console.WriteLine($"Último Elemento de la Pila: {this.array[0]}");
        }
        
        //Métodos de Pila
        public void Imprimir(){
            Console.WriteLine("La Pila es: " + string.Join("-",this.array)); //string.Join(" ", this.array) es una forma de imprimir los valores del arreglo separados por espacios " "
        }

        public void Apilar(int num){
            int tam; //Como los arreglos no se pueden modificar, lo que hacemos es crear una variable para en está guardar el tamaño del array que tenemos para después crear un nuevo arreglo...
            tam = this.array.Length;  //...pero a este le pasamos el tamaño guardado en la variable como parametro pero sumandole 1

            Console.WriteLine("Se Apilará: "+ num);

            int[] aux = new int[tam + 1];
            for(int i = 0; i < tam ; i++){
                aux[i] = this.array[i];
            }
            aux[tam] = num;
            this.array = aux; //guardamos en el array principal nuestro array auxiliar ya que el principal es utilizado en otros métodos 
            //Console.WriteLine("\nLa Nueva Pila: " + string.Join("-", this.array));
        }

        public void Desapilar(){ //no necesita parametro ya que 
            int tam;
            tam = this.array.Length;

            int[] aux = new int[tam - 1];

            Console.WriteLine("Se Desapilará: " + this.array[tam-1]);

            for(int i = 0 ; i < tam-1 ; i++){
                aux[i] = this.array[i];
            }
            this.array = aux;
            Console.WriteLine("\nLa Nueva Pila: " + string.Join("-", this.array));
        }

    }
}
