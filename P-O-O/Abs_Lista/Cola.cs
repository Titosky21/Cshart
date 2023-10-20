using System;

namespace POO_Abs_Lista{
    class Cola : Lista {
        //Atributos
        private int[] array;

        //Constructor 
        public Cola(int[] array){
            this.array = array;
        }

        //Método Abstracto
        public override void Primero(){
            Console.WriteLine($"\nEl Primer Elemento de la  Cola: {this.array[0]}");
        }
        public override void Ultimo(){
            int tam = this.array.Length;
            Console.WriteLine($"El Último Elemento de la Cola : {this.array[tam-1]}");
        }

        //métodos Cola
        public void Imprimir(){
            Console.WriteLine("La Cola es: " + string.Join("-",this.array));
        }

        public void Encolar(int num){
            int tam = this.array.Length;
            int[] aux = new int[tam + 1];

            Console.WriteLine("Se Encolará: " + num);

            for(int i = 0 ; i < tam ; i++){
                aux[i] = this.array[i];
            }
            aux[tam] = num;
            this.array = aux;
            Console.WriteLine("La Nueva Cola es: " + string.Join("-",this.array));
        }

        public void Desencolar(){
            int tam = this.array.Length;
            int[] aux = new int[tam-1];

            Console.WriteLine("Se Desencolará: "+ this.array[0]);

            for(int i = 0 ; i < tam -1 ; i++){
                aux[i] = this.array[i+1];
            }
            this.array = aux;

            Console.WriteLine("\nLa Nueva Cola es: "+ string.Join("-", this.array));

        }

    }
}
