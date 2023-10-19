using System;

namespace POO_Lab_tipoPrueba{
    class Usuario{
        //Atributos
        private string nombre;
        private int numeroIdentificador;
        private List<Abs_Biblioteca> elementosPrestados; //creamos un elemento que solo aceptara objetos tipo "Abs_Biblioteca" osea libros o revistas

        //Constructor
        public Usuario(string nombre, int id){
            this.nombre = nombre;
            this.numeroIdentificador = id;
            this.elementosPrestados = new List<Abs_Biblioteca>(); //creamos una Lista tipo Abs_Biblioteca vacía, esté no se pide por parametro
        }

        //Métodos get
        public string getNombre{
            get { return this.nombre; }
        }

        public int getIdentificacion{
            get { return this.numeroIdentificador; }
        }

        public List<Abs_Biblioteca> getElementosPrestados{
            get { return this.elementosPrestados; }
        }

        //métodos set
        public void prestarElemento(Abs_Biblioteca elemento){
            elementosPrestados.Add(elemento); //al crear 'listas' del tipo "Abs_Biblioteca" estas obtienen las propiedades de las Listas
        }
        public void devolverElemento(Abs_Biblioteca elemento){
            elementosPrestados.Remove(elemento);
        }
        public void MostrarInformacion(){
            Console.WriteLine($"Nombre: {this.nombre}, Número de Identificación: {this.numeroIdentificador}");
            Console.WriteLine($"Elementos Prestados: ");
            foreach(var elemento in elementosPrestados){//el "foreach" es para buscar un tipo de elemento dentro de una lista. 
                elemento.MostrarInformacion();
            }
        }
    }
}
