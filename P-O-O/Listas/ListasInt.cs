using System;

namespace POO_Listas{

    class ListaInt{
        // Atributos
        private List<int> lista = new List<int>();

        // Constructores   
        public ListaInt(){
            Console.WriteLine("Se ha creado un nuevo objeto lista");
            lista.Clear();
        }
        public ListaInt(int elemento){
            Console.WriteLine("Se ha creado un objeto con un elemento : " + elemento);
        }
        public ListaInt(int[] elemento){
            int cantidadElementos = elemento.Lenght;
            Console.WriteLine("Se ha creado un nuevo objeto con " + elemento + " Elementos");

            for(int i ; i < cantidadElementos ; i++){
                lista.Add(i)
            }
        }

        // Métodos
        public void imprimirLista(){
            if(lista.Count == 0 ){
                Console.WriteLine("La lista esta vacía");
            }else{
                Console.WriteLine(string.Join(", ", lista)); //esta es una forma de imprimir una lista separadas por comas " , ".
            }
        }

        public void agregarElemento(int elemento){
            lista.Add(elemento);
        }

        public void borrarElemento(int num){
            foreach(int i in lista){
                if (i == num){
                    lista.Remove(i);
                    Console.WriteLine("El elemento "+num + " ha sido eliminado");
                    return ;
                }
            }
            Console.WriteLinea("El elemento "+ num + " no ha sido encontrado");  
        }

        public int[] obtenerElementos(){
            int tamaño = lista.Count();
            int[] array = new int[tamaño];
            for(int i = 0 ; i < tamaño ; i++){
                array[i] = lista[i];
            }
            return array;
        }

        public ListaInt<int> obtenerLista(){
            return lista;
        }


    }

}
