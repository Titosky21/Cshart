using System;

namespace ActivosTecnologicos{
    class Laptop : Activos {
        //Atributos 
        private int memoriaRAM;

        //Constructor
        public Laptop(string marca,string modelo,int vidaUtilPredeterminada,int anioAdquisicion, int memoriaRAM,MantenimientoActivo elemento,int espacioAlmacenamiento):base(marca,modelo,vidaUtilPredeterminada,estadoFuncionamiento,elemento){
            this.memoriaRAM = memoriaRAM;
        }

        //Métodos Abstractos
        public override void calcularVidaUtilRestante(){
            double vidaUtil = base.VidaUtilPredeterminada - (2023 - (base.AnioDeAdquisicion));
        }
        public override void mostrarInformacion(){
            Console.WriteLine($"\nMarca: {Marca}, Modelo: {Modelo}, Vida Util Predeterminada: {VidaUtilPredeterminada} años, Año de Adquisición: {AnioDeAdquisicion}, ¿Está Funcionando?: {EstadoFuncionamiento}, Memoria RAM (GB): {memoriaRAM}, Mantenimientos: {Mantenimientos}");
        }

        //Métodos Getter and Setter
        public int memoriaRAM{
            get { return this.memoriaRAM; }
            set { this.memoriaRAM = value; }
        }
    }
}
