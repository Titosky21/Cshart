using System;

namespace POO_Abs_Vehiculos{
    abstract class Abs_Concesionaria{
        //Atributos
        private string marca;
        private string modelo;
        private int anio;

        //Constructor
        public Abs_Concesionaria(string marca, string modelo, int anio){
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }

        //Métodos Abstractos
        public abstract void Informacion();

        //Métodos getter and setter
        public string mostrarMarca{
            get { return marca; }
        }
        public string mostrarModelo{
            get { return modelo; }
        }
        public int mostrarAnio{
            get { return anio; }
        }
    }
}
