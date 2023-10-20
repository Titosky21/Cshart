using System;

namespace POO_Asignaturas_ICI{
    class Ciencias_Basicas : Abs_Asignaturas{
        private string libroRecomendado;

        //Constructor
        public Ciencias_Basicas(string libroRecomendado,string nombre,string codigo,int creditos):base(nombre,codigo,creditos){
            this.libroRecomendado = libroRecomendado;
        }

        //Métodos
        public override void areaDominio(){
            Console.WriteLine($"Libro Recomendado: {this.libroRecomendado}");
        }

        public void Aplicacion(){
            
        }
    }
}
