using System;

namespace POO_Abs_Vehiculos{
    class Auto : Abs_Concesionaria {
        //Atributos
        private int puertas;

        //Constructor
        public Auto(string marca, string modelo, int anio, int puertas):base(marca,modelo,anio){
            this.puertas = puertas;
        }

        //Métodos Abstractos
        public override void Informacion(){
            Console.WriteLine($"\nMarca: {mostrarMarca} \nModelo: {mostrarModelo} \nAño: {mostrarAnio} \nPuertas: {puertas}");
        }

    }
}
