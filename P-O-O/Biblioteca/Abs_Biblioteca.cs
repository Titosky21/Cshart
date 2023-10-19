using System;
//using POO_Lab_tipoPrueba;

namespace POO_Lab_tipoPrueba{
    abstract class Abs_Biblioteca{
        //Atributos
        private string titulo;
        private int anioPublicacion;

        //Constructores
        public Abs_Biblioteca(string titulo, int anioPublicacion){
            this.titulo = titulo;
            this.anioPublicacion = anioPublicacion;
        }

        //Métodos
        public string getTitulo{
            get {return this.titulo; }
        }

        public int getAnioPublicacion{
            get { return anioPublicacion; }
        }

        //Método Abstracto 
        public abstract void MostrarInformacion(); //como es un metodo a heredar debe estar con ()
        


    }
}
