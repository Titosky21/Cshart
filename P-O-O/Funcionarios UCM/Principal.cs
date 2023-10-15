using System;
using POO_Funcionarios;

namespace POO_Funcionarios{
    class Principal{
        public static void Main(string[] args){
            Funcionario miFun = new Funcionario("Tito", "ing Informatico",3);
            Funcionario miFun2 = new Funcionario("David", "ing Informatico",3);

            miFun.irReunion();
            miFun2.colar();

            Academico miAcad = new Academico("Hugo",30,"Prof Mat y Comp", "Auxiliar");
            Academico miAcad2 = new Academico("Philip",4,"ing. civil Inf", "instructor");

            miAcad.docencia();
            miAcad2.administrar();
        }
    }
}
