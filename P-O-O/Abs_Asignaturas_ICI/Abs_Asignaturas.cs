using System;

namespace POO_Asignaturas_ICI{
    abstract class Abs_Asignaturas{
        //Atributos
        private string nombre;
        private string codigo;
        private int creditos;

        //Constructor
        public Abs_Asignaturas(string nombre,string codigo, int creditos){
            this.nombre = nombre;
            this.codigo = codigo;
            this.creditos = creditos;
        }

        //Métodos
        public string Nombre{
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Codigo{
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public int Creditos{
            get { return this.creditos; }
            set { this.creditos = value; }
        }
        //Método Abstracto
        public abstract void areaDominio();

    }
}
