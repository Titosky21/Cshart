using System;
using POO_Abs_Lista;

namespace POO_Abs_Lista{
    class Principal{
        public static void Main(string[] args){
            
            int[] array = { 5, 6, 8 };
            Pila pila1 = new Pila(array);

            Cola cola1 = new Cola(array);
                
            //pila1
            pila1.Imprimir();
            pila1.Primero();
            pila1.Ultimo();

            pila1.Apilar(4);
            pila1.Primero();
            pila1.Ultimo();
            pila1.Imprimir();

            pila1.Desapilar();
            pila1.Primero();
            pila1.Ultimo();
            //pila1.Imprimir();

            //Cola1
            cola1.Imprimir();
            cola1.Primero();
            cola1.Ultimo();
            
            cola1.Encolar(4);
            cola1.Primero();
            cola1.Ultimo();
            cola1.Imprimir();

            cola1.Desencolar();
            cola1.Primero();
            cola1.Ultimo();
            //cola1.Imprimir();

        }
    }
}
