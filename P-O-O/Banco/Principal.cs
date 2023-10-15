using System;
class Test{
    public static void Main(string[] args){
        cuentaBanco cuenta1 = new cuentaBanco();
        cuenta1.asignarNombre("Tito");
        cuenta1.asignarCuenta("ABC12345");
        cuenta1.asignarInteres(2.5);

        cuenta1.Deposito(100000);
        cuenta1.Retiro(50000);

        Console.WriteLine(cuenta1.obtenerNombre());
        Console.WriteLine(cuenta1.obtenerCuenta());
        Console.WriteLine(cuenta1.estado());
        Console.WriteLine(cuenta1.obtenerInteres());
    }
}
