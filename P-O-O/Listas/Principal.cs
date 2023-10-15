using System;
using POO_Listas;

namespace POO_Listas{
    class Principal{

        public static void Main(string[] args){
            int[] valores = {1,100,200,20,30};
            ListasInt l1 = new ListasInt(4);
            ListasInt l2 = new ListasInt(valores);

            l1.imprimirLista(); 

            l1.agregarElemento(10);
            l1.imprimirLista();

            l2.imprimirLista();
        }
    }
}
