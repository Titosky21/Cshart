using System;
using POO_Abs_Vehiculos;

namespace POO_Abs_Vehiculos{
    public class Principal{
        public static void Main(string[] args){


            //Vehiculos
            Camioneta cam1 = new Camioneta("simple", "Mitsubishi", "L-200",2023);

            //cam1.Informacion();

            Auto aut1 = new Auto("Toyota","Supra", 2023,2);

            //aut1.Informacion();

            Moto mot1 = new Moto("Honda", "CBR", 2023, 300);

            //mot1.Informacion();

            //Trabajador
            Trabajador trab1 = new Trabajador("Roberto", 2001, "Vendedor");
            trab1.MostrarInformacion();

            //Usuario
            Usuario usurio1 = new Usuario("Tito", 2001);
            usurio1.Informacion();

            //Ejemplo de uso de Prestar Vehiculo
            Console.WriteLine("\nAhora el Usuario pide prestado una Camionate y una Moto");
            usurio1.PrestarVehiculo(cam1);
            usurio1.PrestarVehiculo(mot1);
            usurio1.Informacion();

            //Ejemplo de uso de Devolver Vehiculo
            Console.WriteLine("\nAhora el usuario devuelve una Camioneta");
            usurio1.DevolverVehiculo(cam1);
            usurio1.Informacion();


        }
    }
}

