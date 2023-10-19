using System;
//using POO_Lab_tipoPrueba;

namespace POO_Lab_tipoPrueba{
    class Libro : Abs_Biblioteca{
        //Atributos
        private string autor ;
        private int copiasDisponibles ;

        //Constructor
        public Libro(string titulo, string autor, int anioPublicacion , int copiasDisponibles ):base(titulo,anioPublicacion){
            this.autor = autor;
            this.copiasDisponibles = copiasDisponibles;
        }

        public int getCopiasDisponibles{
            get { return this.copiasDisponibles ; }
            set { this.copiasDisponibles = value ; }
        }

        public override void MostrarInformacion(){//sobreEscritura del metodo abstracto MostrarInformacion por eso se debe usar el comando "override" y hacerlo en cada clase heredada
            Console.WriteLine($"Libro: {getTitulo}, Autor: {this.autor} \nAño de Publicación: {getAnioPublicacion} \nCopias Disponibles: {this.copiasDisponibles} ");
        }
    }
}
