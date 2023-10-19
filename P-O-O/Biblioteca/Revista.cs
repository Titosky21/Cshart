using System;
//using POO_Lab_tipoPrueba;

namespace POO_Lab_tipoPrueba{
    class Revista : Abs_Biblioteca{
        //Atributos
        private string editor ;

        //Construtor
        public Revista(string titulo, string editor, int anioPublicacion):base(titulo,anioPublicacion){
            this.editor = editor;
        }

        //Método
        public string getEditor{
            get { return editor; }
        }

        //Método override
        public override void MostrarInformacion(){
            Console.WriteLine($"Revista: {getTitulo}, Editor: {this.editor}, Año de Publicación: {getAnioPublicacion} ");
        }
    }
}
