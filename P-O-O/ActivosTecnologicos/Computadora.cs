using System;

namespace ActivosTecnologicos{
    class Computadora: Activos {
        //Atributos
        private int espacioAlmacenamiento;

        //Constructor
        public Computadora(string marca,string modelo,int vidaUtilPredeterminada,int anioAdquisicion, bool estadoFuncionamiento,MantenimientoActivo elemento,int espacioAlmacenamiento):base(marca,modelo,VidaUtilPredeterminada,estadoFuncionamiento,elemento){
            this.espacioAlmacenamiento = espacioAlmacenamiento;
        }

        //Métodos Abstractos
        public override void calcularVidaUtilRestante(){
            double vidaUtil = base.VidaUtilPredeterminada - (2023 - (base.AnioDeAdquisicion));
        }
        public override void mostrarInformacion(){
            Console.WriteLine($"\nMarca: {Marca}, Modelo: {Modelo}, Vida Util Predeterminada: {VidaUtilPredeterminada}, Año de Adquisición: {AnioDeAdquisicion}, ¿Está Funcionando?: {EstadoFuncionamiento}, Mantenimientos: {Mantenimientos}, Almacenaminto (GB): {EspacioAlmacenamiento} ");
        }

        //Métodos Getter and Setter 
        public int EstadoFuncionamiento{
            get { return this.espacioAlmacenamiento; }
            set { this.espacioAlmacenamiento = value; }
        }

    }
}
