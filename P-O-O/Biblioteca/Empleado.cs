using System;

namespace POO_Lab_tipoPrueba{
    class Empleado{
        //Atributos 
        private string nombre;
        private int numeroIdentificador;
        private string cargo;

        //Csontructor
        public Empleado(string nombre, int id, string cargo){
            this.nombre = nombre;
            this.numeroIdentificador = id;
            this.cargo = cargo;
        }

        //Métodos
        public string getNombre{
            get { return this.nombre; }
        }

        public int getId{
            get { return this.numeroIdentificador; }
        }
        public string getCargo{
            get { return this.cargo; }
        }

        public void MostrarInformacion(){
            Console.WriteLine($"Empleado: {this.nombre}, Número de Identificación: {this.numeroIdentificador}, Cargo: {this.cargo} ");
        }

    }
}
