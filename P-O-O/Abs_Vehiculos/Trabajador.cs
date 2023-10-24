using System;

namespace POO_Abs_Vehiculos{
    class Trabajador{
        //Atributos
        private string nombre;
        private int Identificación;
        private string cargo;

        //Constructor
        public Trabajador(string nombre, int id, string cargo){
            this.nombre = nombre;
            this.Identificación = id;
            this.cargo = cargo;
        }

        //Metodos get
        public string getNombre{
            get { return this.nombre; }
        }
        public int getIdentificacion{
            get { return this.Identificación; }
        }
        public string getCargo{
            get { return this.cargo; }
        }

        //Método set
        public void MostrarInformacion(){
            Console.WriteLine($"\nTrabajador: {this.nombre}, Número de Identificación: {this.Identificación}, Cargo: {this.cargo} ");
        }
    }
}
