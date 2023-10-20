using System;

namespace POO_Asignaturas_ICI{
    class Formacion_General : Abs_Asignaturas{

        //constructor

        public Formacion_General(string nombre,string codigo,int creditos):base(nombre,codigo,creditos){
            
        }

        public override void areaDominio(){
            Console.WriteLine("Hola");
        }
        
    }
}
