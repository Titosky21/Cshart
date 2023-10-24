using System;

namespace POO_Abs_Vehiculos{
    class Camioneta : Abs_Concesionaria {
        //Atributos 
        private string cabina;

        //Constructor
        public Camioneta(string cabina, string marca, string modelo, int anio):base(marca,modelo,anio){
            this.cabina = cabina;
        }

        //Métodos Abstractos
        public override void Informacion(){
            Console.WriteLine($"\nMarca: {mostrarMarca} \nModelo: {mostrarModelo} \nAño: {mostrarAnio} \nCabina: {cabina}");
        }

    }
}
