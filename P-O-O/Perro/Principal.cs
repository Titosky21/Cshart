using System.IO.Pipes;

class Test{
    public static void Main(string[] args){
        Perro perro1 = new Perro();

        perro1.asignarNombre("Aroha");
        Console.WriteLine("Tenemos un perro de nombre : " + perro1.obtenerNombre());


    }
}
