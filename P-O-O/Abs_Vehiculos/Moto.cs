using System;

namespace POO_Abs_Vehiculos{
    class Moto : Abs_Concesionaria {
        //Atributos
        private int cilindraje;

        //Constructor
        public Moto(string marca, string modelo, int anio, int cilindraje):base(marca, modelo, anio){
            this.cilindraje = cilindraje;
        }
        //Métodos Abstractos
        public override void Informacion(){
            Console.WriteLine($"\nMarca: {mostrarMarca} \nModelo: {mostrarModelo} \nAño: {mostrarAnio} \nCilindraje: {cilindraje}");
        }
    }
}
