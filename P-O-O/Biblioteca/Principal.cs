using System;
using POO_Lab_tipoPrueba;

namespace POO_Lab_tipoPrueba{
    class Principal{
        public static void Main(string[] args){
            
            //Ejemplo de uso de las clases Revista y Libro
            Libro libro1 = new Libro("Cien años de soledad","Gabriela Mistral", 1967, 5);

            Revista revista1 = new Revista("National Geographic", "National Geographic Society", 2022);

            libro1.MostrarInformacion();

            revista1.MostrarInformacion();

            //Ejemplo de uso de las clases Empleado y Usuario
            Empleado empleado1 = new Empleado("Ana", 1001, "Bibliotecaria");
            Usuario usuario1 = new Usuario("Juan", 1001);

            empleado1.MostrarInformacion();
            usuario1.MostrarInformacion();

            //Ejemplo de uso de Prestar Elemento
            Console.WriteLine("\nAhora el usuario pide prestado un libro y revista");
            usuario1.prestarElemento(libro1);
            usuario1.prestarElemento(revista1);
            usuario1.MostrarInformacion();

            //Ejemplo de uso de Devolver Elemento
            Console.WriteLine("\nEl usuario acaba de devolver el libro");
            usuario1.devolverElemento(libro1);
            usuario1.MostrarInformacion();

        }
    }
}

