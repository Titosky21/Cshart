using System;

namespace POO_Abs_Vehiculos{
    class Usuario{
        //Atributos
        private string nombre;
        private int Identificación;
        private List<Abs_Concesionaria> prestarVehiculo;

        //Constructor
        public Usuario(string nombre,int id){
            this.nombre = nombre;
            this.Identificación = id;
            this.prestarVehiculo = new List<Abs_Concesionaria>();
        }

        //Método get
        public string getNombre{
            get { return this.nombre; }
        }
        public int getIdentificacion{
            get { return this.Identificación; }
        }
        public List<Abs_Concesionaria> getPrestarVehiculo{
            get { return this.prestarVehiculo; }
        }

        //Métodos set
        public void PrestarVehiculo(Abs_Concesionaria elemento){
            prestarVehiculo.Add(elemento);
        }
        public void DevolverVehiculo(Abs_Concesionaria elemento){
            prestarVehiculo.Remove(elemento);
        }
        public void Informacion(){
            Console.WriteLine($"Usuario: {this.nombre}, Número de Identificación: {this.Identificación}");
            Console.WriteLine($"Elementos Prestados: ");
            foreach(var elemento in prestarVehiculo){
                elemento.Informacion();
            }
        }
    }
}
