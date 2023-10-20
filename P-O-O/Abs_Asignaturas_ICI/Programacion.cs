using System;

namespace POO_Asignaturas_ICI{
    class Programacion : Abs_Asignaturas{
        //Atributos
        private string lenguajePrincipal;

        //Constructor
        public Programacion(string lenguajePrincipal,string nombre,string codigo,int creditos):base(nombre,codigo,creditos){
            this.lenguajePrincipal = lenguajePrincipal;
        }

        //Métodos
        public override void areaDominio(){
            Console.WriteLine($"\nNombre: {Nombre} \nLenguaje Principal: {Lenguaje} \nCodigo: {Codigo} \nCreditos: {Creditos} ");
        }

        public string Lenguaje{
            get { return this.lenguajePrincipal; }
        }

    }
}
